using System;

namespace TextEditorApplication
{
    //Invoker
    public class CommandInvoker
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public void Execute(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
        }

        public void Undo()
        {
            if (_commands.Any())
            {
                var command = _commands.Pop();
                command.Undo();
            }
        }
    }
}
