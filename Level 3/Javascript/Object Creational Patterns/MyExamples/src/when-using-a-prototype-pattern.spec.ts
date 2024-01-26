interface Cloneable {
    clone(): Cloneable;
}
  
class GameObject implements Cloneable {
    constructor(private sprite: string, private position: number) {}
  
    clone() {
      return new GameObject(this.sprite, this.position);
    }
  
    describe() {
      console.log(`Sprite: ${this.sprite}, Position: ${this.position}`);
    }
}

describe('gameObject', () => {

    it('should create a game object with specified sprite and position', () => {
        // Arrange
        const initialSprite = 'player'
        const initialPosition = 100
        // Act
        const gameObject = new GameObject(initialSprite, initialPosition)
        // Assert
        expect(gameObject).toBeInstanceOf(GameObject)
        expect(gameObject['sprite']).toBe(initialSprite)
        expect(gameObject['position']).toBe(initialPosition)
    })

    it('should create a new game object with the same properties when clone method is called', () => {
        // Arrange
        const initialSprite = 'player'
        const initialPosition = 100
        // Act
        const gameObject = new GameObject(initialSprite, initialPosition)
        const clonedObject = gameObject.clone()
        // Assert
        expect(clonedObject).toBeInstanceOf(GameObject)
        expect(clonedObject['sprite']).toBe(initialSprite)
        expect(clonedObject['position']).toBe(initialPosition)
    })

    it('should print out the sprite and position information when describe method is called', () => {
        // Arrange
        const initialSprite = 'player'
        const initialPosition = 100
        const consoleSpy = jest.spyOn(console, 'log').mockImplementation(() => {})
        // Act
        const gameObject = new GameObject(initialSprite, initialPosition)
        gameObject.describe()
        // Assert
        expect(consoleSpy).toHaveBeenCalledWith(`Sprite: ${initialSprite}, Position: ${initialPosition}`)
    
        consoleSpy.mockRestore()
      })
})