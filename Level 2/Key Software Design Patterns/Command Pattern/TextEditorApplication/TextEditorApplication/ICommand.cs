using System;

namespace TextEditorApplication
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
