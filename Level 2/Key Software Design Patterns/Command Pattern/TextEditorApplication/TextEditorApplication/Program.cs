namespace TextEditorApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var editor = new TextEditor();
            var invoker = new CommandInvoker();

            var command1 = new SetTextCommand(editor, "World");
            var command2 = new SetTextCommand(editor, "Hello");

            invoker.Execute(command1);
            invoker.Execute(command2);

            Console.WriteLine(editor.GetText()); //Output: World

            invoker.Undo();

            Console.WriteLine(editor.GetText()); //Output: Hello

            Console.ReadKey();
        }
    }
}