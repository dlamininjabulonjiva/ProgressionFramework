Single Responsibility Principle
	- SRP states that a class should have only one reason to change.
	- So we should gather together the things that change for the same reason. Separate the things that change for different reasons.
	
In this project I have refactored my code so that there is a class that is solely responsible for any User logic (Create, Process etc).
I also have another class that is solely responsible for emails, whether it is validating or sending them.