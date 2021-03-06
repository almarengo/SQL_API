using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Cut Bread", Line="Get a knife", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Make cup of tea", Line="Boil Water", Platform="Kettle"},
                new Command{Id=2, HowTo="Boil an egg", Line="Place teabag", Platform="Kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pan"};
        }
    }
}