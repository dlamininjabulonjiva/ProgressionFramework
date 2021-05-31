describe('Calculation', () =>{
    it('given invalid number should return 0', () => {
		// Arrange
		const num1 = "num1";
		const num2 = 5;
		const expected = 0;
		// Act
		var actual = calculationFor(num1, num2, operators.Add);
		// Assert
		expect(actual).toBe(expected);
	});

    it('given invalid operator should return 0', () => {
		// Arrange
		const num1 = "num1";
		const num2 = 5;
		const expected = 0;
		// Act
		var actual = calculationFor(num1, num2, "+");
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate the sum of two numbers', () => {
		// Arrange
		const num1 = 5;
		const num2 = 5;
		const expected = 10;
		// Act
		var actual = calculationFor(num1, num2, operators.Add);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate the difference of two numbers', () => {
		// Arrange
		const num1 = 25;
		const num2 = 5;
		const expected = 20;
		// Act
		var actual = calculationFor(num1, num2, operators.Subtract);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate the product for two numbers', () => {
		// Arrange
		const num1 = 25;
		const num2 = 5;
		const expected = 125;
		// Act
		var actual = calculationFor(num1, num2, operators.Multiply);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate the quotient of two numbers', () => {
		// Arrange
		const num1 = 25;
		const num2 = 5;
		const expected = 5;
		// Act
		var actual = calculationFor(num1, num2, operators.Divide);
		// Assert
		expect(actual).toBe(expected);
	});

    it('given quotient Nan should return 0', () => {
		// Arrange
		const num1 = 0;
		const num2 = 0;
		const expected = 0;
		// Act
		var actual = calculationFor(num1, num2, operators.Divide);
		// Assert
		expect(actual).toBe(expected);
	});
});