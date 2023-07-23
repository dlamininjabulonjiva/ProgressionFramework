describe('this keyword in global context', function() {
    it("should refer to the global object in the global context", function() {
        // Arrange
        const expected = window;
        // Act
        const globalThis = testThisInGlobalContext();
        // Assert
        expect(globalThis).toBe(expected);
    });
});