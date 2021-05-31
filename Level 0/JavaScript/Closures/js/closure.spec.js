describe('Closures', function() {
	it('should increment current age by the given number', function(){
		// Arrange
        const number = 2;
        const expected = 22;
        // Act
        var actual = incrementCurrentAgeByValue(number);
        // Assert
        expect(actual).toBe(expected);
	});

    it('should increment counter', function(){
		// Arrange
        const expected = 4;
        // Act
        incrementCounter();
        incrementCounter();
        incrementCounter();
        var actual = incrementCounter();
        // Assert
        expect(actual).toBe(expected);
	});

    it('should multiply two numbers', function(){
		// Arrange
        const num1 = 5;
        const num2 = 15;
        const expected = 75;
        // Act
        var multiply = doMultiplication(num1);       
        var actual = multiply(num2);
        // Assert
        expect(actual).toBe(expected);
	});

    it('should calculate the total of the numbers', function(){
		// Arrange
        const expected = 90;
        // Act     
        var actual = calculateTotal(15)(5)(20)(40);
        // Assert
        expect(actual).toBe(expected);
	});
});