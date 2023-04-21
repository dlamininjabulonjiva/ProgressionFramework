# Reflection
- Reflection is a powerful mechanism in C# that allows you to inspect and manipulate metadata of types and their members at runtime.
- With reflection, you can dynamically create new types, inspect existing ones, call their methods, and access their properties and fields.

# To use reflection in C#, you need to include the System.Reflection namespace in your code. The key classes in this namespace are:
- Type: Represents a type in C#. You can use this class to inspect the metadata of a type and its members.
- PropertyInfo: Represents a property of a type. You can use this class to get or set the value of a property.
- FieldInfo: Represents a field of a type. You can use this class to get or set the value of a field.
- MethodBase: Represents a method of a type. You can use this class to invoke a method or inspect its metadata.

In this example, I defined a class MyClass with two properties. I then create an instance of MyClass and set its properties.
I used reflection to get the Type object for the instance and use the GetProperties method to retrieve an array of PropertyInfo objects that represent the public instance properties of the object.
I then iterate through the array and use the GetValue method of each PropertyInfo object to get the value of the corresponding property of the object.
Finally, I print the names and values of the properties to the console.

This example shows how you can use reflection to dynamically inspect the properties of an object at runtime. Reflection provides a powerful mechanism for working with metadata in C# and can be used in many different scenarios, such as serialization, code generation, and testing.