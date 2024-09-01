using System;

namespace Command
{
	internal class DataCommandInvoker
    {
        private ICommand? command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
            Console.WriteLine($"Command {command.GetType()} set.");
        }

        public void ExecuteCommand()
        {
            command?.Execute();
        }
    }
}
