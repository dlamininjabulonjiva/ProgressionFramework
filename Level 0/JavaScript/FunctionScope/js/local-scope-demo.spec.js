describe('Local Variables Demo', () => {
    it('should calculate the number of characters in a given string', () => {
		// Arrange
        const input = "I am learning new things"
		const expected = 24;
		// Act
		var actual = calculateNumberOfCharacters(input);
		// Assert
		expect(actual).toBe(expected);
	});

    it('should calculate the square of the sum', () => {
		// Arrange
		const expected = 2025;
		// Act
		var actual = calculateTheSquareOfTheSum();
		// Assert
		expect(actual).toBe(expected);
	});
});