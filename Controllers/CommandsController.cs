using System.Collections.Generic;
using Commander.Data;
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

        public CommandsController(ICommanderRepo repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllCommands()
        {
            var commandsItems = _repository.GetAppCommands();
            
            return Ok(commandsItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}