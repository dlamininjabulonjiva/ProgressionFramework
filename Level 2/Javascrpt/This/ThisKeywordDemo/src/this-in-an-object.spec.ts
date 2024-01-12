const carDetails = {
    model: '123',
    brand: 'Toyota',
    color: 'blue',
    price: 1180000,
    quantity: 3,
    description: function () {
      return `${this.quantity} ${this.color} ${this.brand} car(s) at ${this.price} rands`;
    },
};
  
describe('this in an object', () => {
    it('can reference property values from within the object', () => {
        // Arrange
        // Act
        const result = carDetails.description()
        // Assert
        expect(result).toEqual('3 blue Toyota car(s) at 1180000 rands')
    })
})
  