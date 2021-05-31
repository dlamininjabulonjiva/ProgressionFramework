describe('Employee', () => {
	it('should return employee full name', () => {
		// Arrange
        const expected = "Jacob Mnisi";
        var employee = new Employee("Jacob", "Mnisi", "C15", "Software Developer")
        // Act
        var actual = employee.getEmployeeFullName();
        // Assert
        expect(actual).toBe(expected);
	});

    it('should return the employee position', () => {
		// Arrange
        const expected = "Employee with employee number(C15) is a Software Developer";
        var employee = new Employee("Jacob", "Mnisi", "C15", "Software Developer")
        // Act
        var actual = employee.getEmployeePosition();
        // Assert
        expect(actual).toBe(expected);
	});

    it('should return the employee address', () => {
		// Arrange
        const expected = "Jacob Mnisi lives in 385 smith street, Durban, 4000";
        var employee = new Employee("Jacob", "Mnisi", "C15", "Software Developer")
        // Act
        var actual = employee.getEmployeeAddress();
        // Assert
        expect(actual).toBe(expected);
	});
});