const sound = {
    make: function (name: string, punctuation: string) {
      return `${name} has a very ${this.level} ${this.sound}${punctuation}`
    },
}
  
describe('this with call', () => {
    it('alows specifying the context of this and passsing in arguments', () => {
        // Arrange
        const softLaugh = {
            level: 'soft',
            sound: 'laugh',
        }
        // Act
        const result = sound.make.call(softLaugh, 'Thomas', '.')
        // Assert
        expect(result).toEqual('Thomas has a very soft laugh.')
    })
})

describe('this with apply', () => {
    it('allows specifying the context of this and passing in arguments', () => {
        // Arrange
        const loudGiggle = {
            level: 'loud',
            sound: 'giggle',
        }
        // Act
        const result = sound.make.apply(loudGiggle, ['Jessica', '!'])
        // Assert
        expect(result).toEqual('Jessica has a very loud giggle!')
    })
})
  