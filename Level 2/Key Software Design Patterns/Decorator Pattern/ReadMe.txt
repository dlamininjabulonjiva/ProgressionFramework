The decorator pattern is a design pattern in software engineering that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.
It is a structural pattern that allows us to add functionality to an object at runtime by wrapping it in a decorator class.

The decorator pattern consists of a component interface, a concrete component class, a decorator abstract class, and several concrete decorator classes.
The component interface defines the methods that will be implemented by the concrete component class and the decorator abstract class. 
The concrete component class is the object that we want to decorate, and the decorator abstract class defines the interface for all decorators.
The concrete decorator classes are subclasses of the decorator abstract class that add functionality to the decorated object.