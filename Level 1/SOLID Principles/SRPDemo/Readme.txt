Single Responsibility Principle
	- SRP states that a class should have only one reason to change.
	- So we should gather together the things that change for the same reason. Separate the things that change for different reasons.

I have created 2 project to Demostrate SRP. One project shows code violationg the SRP and the other shows code that conforms to SRP.
Both these project asks for the user's first and last names, validates both names and generates a username for that user.

PLEASE NOTE:
There is still stuff that I could change which I ignored intentionally in the 'CodeThatConformsToSRP project'.
E.g. I am newing up a user in the Program.cs and that is really tightly coupled. But will get to that when I get to the other principle that focuses on this, for now I'm just focusing on SRP.