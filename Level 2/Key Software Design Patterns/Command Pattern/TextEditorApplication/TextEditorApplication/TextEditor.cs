using System;

namespace TextEditorApplication
{
    //Receiver
    public class TextEditor
    {
        private string _text;

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
