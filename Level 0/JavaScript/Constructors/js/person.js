// Class Constructor Example
class Person {
    constructor(firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
    }

    getDetails() {
        return this.firstName + " " + this.lastName + " is a " + this.gender + " and is " + this.age + " years old";
    }
}