# This Keyword
- In JavaScript, "this" is a keyword that refers to the current execution context, specifically the value of the "this" keyword is determined by how a function is called.
- The value of "this" can change depending on the context in which the function is called.

# The following are some examples of how this behaves in different scenarios:

	## Global context:
		- When this is used in the global scope (outside of any function), it refers to the global object (in browsers, it's window).
		
	## Object method context:
		- When this is used within an object method, it refers to the object itself, i.e., the object that owns the method.
		
	## Function context:
		- When this is used within a regular function (not an arrow function), its value depends on how the function is called.