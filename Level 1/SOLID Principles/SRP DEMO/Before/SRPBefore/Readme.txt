Single Responsibility Principle
	- SRP states that a class should have only one reason to change.
	- So we should gather together the things that change for the same reason. Separate the things that change for different reasons.

This project violates the Single Responsibility Principle. Why?
	- This project has a UserService class which has four responsibilities
		1. Create a user account
		2. Validate the user’s email address
		3. Process user data
		4. Send a welcome email
The code in this project will work perfectly but will lead to some challenges in the fture.