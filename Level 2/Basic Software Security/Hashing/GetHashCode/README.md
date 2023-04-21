# Overriding Gethashcode and equals on system.object
In this example, I defined a custom class Person with two properties(Name and Age). I overrode the Equals and GetHashCode methods to compare Person objects based on their Name and Age properties.
I also wrote unit tests to verify that my hash code and equality methods work correctly.

# Equals Method
The Equals method overrides the default implementation in the Object class. It takes an object as a parameter and returns a bool value indicating whether the current Person object is equal to the obj parameter.

In the first line of the method, I check if the obj parameter is null or has a different type than the current Person object. If either of these conditions is true, I return false because the objects cannot be equal.
Next, I cast the obj parameter to a Person object and stored it in a local variable otherPerson.

Finally, I compared the Name and Age properties of the current Person object and the otherPerson object using the == operator. If both properties are equal, I return true. Otherwise, I return false.

# GetHashCode Method
The GetHashCode method also overrides the default implementation in the Object class. It returns an int value that represents a hash code for the current Person object. In the method,
I call the GetHashCode method on the Name and Age properties of the current Person object, which returns their respective hash codes.

Then, I use the XOR(exclusive or) '^' operator to combine the hash codes into a single value. This ensures that the resulting hash code is unique to the current Person object and is not affected by the order of the properties.
