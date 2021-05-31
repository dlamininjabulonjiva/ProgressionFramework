function getEmployeeDetails() {
    // assigning values before variables are declared
    employeeName = "Thomas Bhengu";
    employeeNumber = "E21101902";
    employeePosition = "Leve 2 Software Developer";

    // declaring variables
    var employeeName;
    var employeeNumber;
    var employeePosition;

    return employeeName + " with employee number(" + employeeNumber + ")" + " is a " + employeePosition;
}

function getStudentNameByStudentNumber(studentList, studentNumber) {
    const students = typeof studentList === "object" ? studentList : [];
    
    // assigning a value before variable is declared   
    studentName = students.find(s => s.studentNumber === studentNumber).name;

    // declaring a variable
    var studentName;

    return studentName;
} 