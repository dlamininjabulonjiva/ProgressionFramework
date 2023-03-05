The Command pattern is a behavioral design pattern that encapsulates a request or an operation into a separate object, allowing for decoupling between the sender and the receiver of the request.
It is useful in situations where the request needs to be queued, logged, undoable, or otherwise manipulated. The pattern is composed of several classes that represent the command, the invoker, and the receiver.

In the Command pattern, the command itself is a separate class that encapsulates the method invocation, along with its parameters and context.
The invoker class is responsible for executing the command and possibly queuing or logging it. The receiver class is the object that actually performs the operation.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
In this example, I have a TextEditor class that represents the receiver object. It has two methods: SetText and GetText, which set and get the text of the editor, respectively.

The ICommand interface defines the Execute and Undo methods. The SetTextCommand class is a concrete command that implements the ICommand interface.
It takes the TextEditor object and the new text as parameters and stores the previous text in a field. The Execute method sets the new text, while the Undo method sets the previous text.

The CommandInvoker class is the invoker object that executes the commands. It has a stack of commands and two methods: Execute and Undo.
The Execute method executes the command and pushes it onto the stack, while the Undo method pops the last command from the stack and undoes it.