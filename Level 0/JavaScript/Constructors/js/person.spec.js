describe('Person', () => {
	it('should return person details', () => {
		// Arrange
		const expected = "Innocent Walaza is a Male and is 28 years old";
		var person = new Person("Innocent", "Walaza", 28, "Male")
		// Act
		var actual = person.getDetails();
		// Assert
		expect(actual).toBe(expected);
	});
});