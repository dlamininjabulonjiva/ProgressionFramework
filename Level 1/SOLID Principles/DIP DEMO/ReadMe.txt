Dependancy Inversion Principle consists of 2 rule
	- High level modules should not depend on low level modules, both should depend on abstractions.
	- Abstractions should not depend on details. Details should depend upon abstractions.
	
I have created two projects which do the following:
	1. They calculate the salary of an employee (it can be Gross, Nett e.t.c)
	
In the DIPBefore project, DIP is violated in the Employee class. The Employee class uses the concrete Salary class and therefore it is tightly coupled, any change in the Salary class will break the code.
So here the Employee class is a high level module, and Salary class is a low level module. So according to the first rule of DIP, Employee should not depend on concrete Salary class. Both should depend on abstractions.