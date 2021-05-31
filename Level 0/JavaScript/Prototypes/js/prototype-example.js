function Employee(name, surname, empNo, empPosition){
    this.name = name;
    this.surname = surname;
    this.empNo = empNo;
    this.empPosition = empPosition;
}

// adding a new property to object contructor
Employee.prototype.address = "385 smith street, Durban, 4000";

// adding a new methods to object contructor
Employee.prototype.getEmployeeFullName = function () {
    return this.name + " " + this.surname;
}

Employee.prototype.getEmployeePosition = function () {
    return "Employee with employee number(" + this.empNo + ")" + " is a " + this.empPosition;
}

Employee.prototype.getEmployeeAddress = function () {
    const fullName = this.getEmployeeFullName();
    return fullName + " lives in " + this.address;
}