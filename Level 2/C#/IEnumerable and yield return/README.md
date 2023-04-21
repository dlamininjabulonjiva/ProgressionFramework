# IEnumerable
- In C#, IEnumerable is an interface that provides a way to iterate over a collection of objects. It defines a method called GetEnumerator() that returns an object that can be used to iterate over the collection.

# yield return
- The yield return statement is used in C# to return a sequence of values from a method, without having to create a separate collection to store them.
- It allows you to create an iterator block, which is a way to generate a sequence of values on the fly as they are needed, rather than generating the entire sequence at once.
	
In this example, I defined a class called FibonacciSequence that implements the IEnumerable interface. It contains a method called GetEnumerator() that uses the yield return statement to generate the sequence of Fibonacci numbers.
