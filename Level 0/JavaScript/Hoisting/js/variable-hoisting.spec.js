describe('Variable Hoisting', () => {
	it('should return employee details',  () => {
		// Arrange
        const expected = "Thomas Bhengu with employee number(E21101902) is a Leve 2 Software Developer"
        // Act
        var actual = getEmployeeDetails();
        // Assert
        expect(actual).toBe(expected);
	});

    it('should return the student name',  () => {
		// Arrange
        const studentNumber = "21101902";
        const studentList = [
            { name: 'Frank', studentNumber: '21101902' },
            { name: 'Sarah', studentNumber: '21101903' },
            { name: 'Michael', studentNumber: '21101904' },
            { name: 'Jessy', studentNumber: '21101905' },
            { name: 'David', studentNumber: '21101906' },
            { name: 'Jabari', studentNumber: '21101907' },
        ];
        const expected = "Frank"
        // Act
        var actual = getStudentNameByStudentNumber(studentList, studentNumber);
        // Assert
        expect(actual).toBe(expected);
	});
});