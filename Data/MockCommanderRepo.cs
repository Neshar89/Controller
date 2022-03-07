using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an eggr", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=0, HowTo="Cut bread", Line="Get a knife", Platform="Knife"},
                new Command{Id=0, HowTo="Make cup of tea", Line="Place teabag and a cup", Platform="Kettle and Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an eggr", Line="Boil water", Platform="Kettle and Pan"};
        }
    }
}