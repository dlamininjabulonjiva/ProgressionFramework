describe("Function context - calculateAge", function() {
  it("should correctly calculate age based on birth year", function() {
    // Arrange
    const person1 = { birthYear: 1990 };
    const person2 = { birthYear: 1993 };

    // Attach the calculateAge function to the person objects
    person1.calculateAge = calculateAge;
    person2.calculateAge = calculateAge;

    const calculateAgeSpyP1 = spyOn(person1, 'calculateAge').and.callThrough();
    const calculateAgeSpyP2 = spyOn(person2, 'calculateAge').and.callThrough();

    const date = new Date();
    const currentYear = date.getFullYear();
    //Act
    const person1Result = person1.calculateAge(currentYear);
    const person2Result = person2.calculateAge(currentYear);
    //Assert
    expect(calculateAgeSpyP1).toHaveBeenCalled();
    expect(calculateAgeSpyP1.calls.first().object).toBe(person1);
    expect(person1Result).toBe(currentYear - person1.birthYear);

    expect(calculateAgeSpyP2).toHaveBeenCalled();
    expect(calculateAgeSpyP2.calls.first().object).toBe(person2);
    expect(person2Result).toBe(currentYear - person2.birthYear);
  });
});