describe('this keyword in object method context', function() {
    it("should refer to the object itself in the object method context", function() {
      // Arrange  
      const person = jasmine.createSpyObj("person", ["greet"]);
      person.name = "John";
      person.greet.and.callFake(function() {
        return `Hello, my name is ${this.name}`;
      });
      // Act
      const actual = person.greet()
      // Assert
      expect(actual).toBe("Hello, my name is John");
    });
});