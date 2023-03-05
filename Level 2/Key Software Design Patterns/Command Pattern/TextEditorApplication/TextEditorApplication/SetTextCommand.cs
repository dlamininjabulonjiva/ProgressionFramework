using System;

namespace TextEditorApplication
{
    //Concrete Command
    public class SetTextCommand: ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _text;

        private string _previousText;

        public SetTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _previousText = _editor.GetText();
            _editor.SetText(_text);
        }

        public void Undo()
        {
            _editor.SetText(_previousText);
        }
    }
}
