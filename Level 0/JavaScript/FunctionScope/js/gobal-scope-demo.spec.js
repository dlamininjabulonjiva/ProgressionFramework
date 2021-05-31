describe('Global Variables Demo', () => {
    it('should calculate the sum of the two numbers', () => {
		// Arrange
		const expected = 25;
		// Act
		var actual = calculateSum();
		// Assert
		expect(actual).toBe(expected);
	});

    it('should calculate the square of the first number', () => {
		// Arrange
		const expected = 225;
		// Act
		var actual = calculateSquareOfNumOne();
		// Assert
		expect(actual).toBe(expected);
	});

    it('should calculate the cube of the secont number', () => {
		// Arrange
		const expected = 1000;
		// Act
		var actual = calculateCubeOfNumTwo();
		// Assert
		expect(actual).toBe(expected);
	});
});