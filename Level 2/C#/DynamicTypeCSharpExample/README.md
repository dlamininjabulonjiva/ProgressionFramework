# Dynamic
- In computer programming, "dynamic" refers to a type of programming language feature that allows for dynamic typing and binding of objects at runtime, rather than at compile time. In other words, it allows for objects to be created and manipulated without specifying their data types in advance.
- C# is a statically-typed language, meaning that data types are specified at compile-time. However, C# also includes the "dynamic" keyword, which allows for dynamic typing of objects.
- Dynamic typing can be useful in situations where the data type of an object is not known in advance, such as when working with data from external sources or when using reflection to dynamically invoke methods.
	
In this example, I create two dynamic variables, value1 and value2, and assign them values of different types - int and string, and then string and double, respectively. I then print out the type of each variable using the GetType() method.

At runtime, the dynamic typing allows the variable value1 to be reassigned to a string value, and the variable value2 to be reassigned to a double value. The GetType() method correctly reports the new types of the variables.
