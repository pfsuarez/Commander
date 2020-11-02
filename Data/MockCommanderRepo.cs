using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 2, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & chopping board" },
                new Command { Id = 3, HowTo = "Make a cup of tea", Line = "Place teabag in cup", Platform = "Kettle & cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }
    }
}