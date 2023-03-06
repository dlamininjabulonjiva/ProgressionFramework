This Keyword
- In JavaScript, "this" is a keyword that refers to the current execution context, specifically the value of the "this" keyword is determined by how a function is called.
- The value of "this" can change depending on the context in which the function is called.

---------------------------------------------------------------------------------------------------------------------------------------------------
In this example, I have a Person class with methods for adding and removing friends, and for introducing themselves along with their list of friends.
The this keyword is used extensively to refer to the instance of the class being manipulated, as well as to other instances of the class when adding or removing friends.

I create three instances of the Person class, john, mary, and bob, and call the addFriend method on them to establish a mutual friendship between all three.
I then call the introduce method on each instance to output information about themselves and their friends.
I then call the removeFriend method on john to remove his friendship with mary, and call the introduce method again on each instance to see the updated list of friends.

In this example, the this keyword is used in several different ways for different instances of the Person class:

1. Inside the constructor method, this is used to refer to the instance of the Person class being created, and is used to assign the name, age, and friends properties to that instance.
2. Inside the greet method, this is used to refer to the instance of the Person class that is calling the method, and is used to construct a greeting string containing the person's name and age.
3. Inside the addFriend method, this is used to refer to the instance of the Person class that is adding a friend, and is used to push the friend onto the friends array of that instance.
4. Inside the removeFriend method, this is used to refer to the instance of the Person class that is removing a friend, and is used to splice the friend from the friends array of that instance.
5. Inside the introduce method, this is used to refer to the instance of the Person class that is introducing themselves, and is used to construct a string containing the person's name and age, as well as a list of their friends' names.
6. Inside the addFriend and removeFriend methods, this is also used to refer to the instance of the Person class being passed as an argument, and is used to call the corresponding method on that instance, in order to establish or remove the friendship relationship between the two instances.