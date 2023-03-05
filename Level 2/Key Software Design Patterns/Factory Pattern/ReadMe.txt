The Factory Pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
The Factory Pattern is useful when creating objects with different implementations but similar interfaces.

In this example, I have an interface ICake that defines the behavior for the product. I also have three concrete implementations of the ICake interface: ChocolateCake, ButterCake and VanillaCake.

I then define the CakeFactory class, which has a method CreateCake that takes in an enum representing the type of cake to create.
Based on the enum, the factory creates an instance of either the ChocolateCake, ButterCake or VanillaCake class.