using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            this._repository = repository;
            this.mapper = mapper;
        }

        // GET api/commands
        [HttpGet]
        public IActionResult GetAllCommands()
        {
            var commandsItems = _repository.GetAllCommands();
            
            return Ok(mapper.Map<IEnumerable<CommandReadDto>>(commandsItems));
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public IActionResult GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            if(commandItem == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<CommandReadDto>(commandItem));
        }
    }
}