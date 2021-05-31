describe('Function Hoisting', () => {
	it('should return the total',  () => {
		// Arrange
        const num1 = 10;
        const num2 = 20;
        const expected = 30;
        // Act
        var actual = add(num1, num2);
        // add will be hoisted in this case
        function add(num1, num2) {
            const total = num1 + num2;
            return total;
        }
        // Assert
        expect(actual).toBe(expected);
	});

    it('should fail to greet',  () => {
        // Arrange
        const firstName = "Njabulo";
        const expected = "Hello Njabulo";
        // Act
        try {
            let actual = greeting(firstName);
            var greeting = function (name) {
                return 'Hello ' + name;
            }
        }
        catch(e) {
            // Assert
            expect(e).not.toBeNull();
            return;
        }
        fail('expected to catch an exception');            
    });

    it('should fail to greet',  () => {
        // Arrange
        const firstName = "Njabulo";
        const expected = "Hello Njabulo";
        // Act
        var greeting = function (name) {
            return 'Hello ' + name;
        }
        let actual = greeting(firstName);
        // Assert
        expect(actual).toBe(expected);
    });
});





