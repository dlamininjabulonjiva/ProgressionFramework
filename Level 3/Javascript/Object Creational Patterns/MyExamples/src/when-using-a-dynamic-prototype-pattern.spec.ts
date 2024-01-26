class ComputerDynamicPrototype {
    ram: string;
    hardDisk: string;
  
    constructor(ram: string, hardDisk: string) {
      this.ram = ram;
      this.hardDisk = hardDisk;
  
      // Dynamically add AvailableMemory method if not present
      if (typeof this.AvailableMemory !== 'function') {
        ComputerDynamicPrototype.prototype.AvailableMemory = function () {
          console.log('\nHarddisk is : ' + this.hardDisk);
          console.log('Ram is : ' + this.ram);
        };
      }
    }
  
    AvailableMemory?(): void; // Optional method definition
}

describe('computerDynamicPrototype', () => {
    it('should create a computer dynamic prototype with specified ram and hard disk', () => {
        // Arrange
        const ram = '8GB'
        const hardDisk = '256GB SSD'
        const consoleSpy = jest.spyOn(console, 'log').mockImplementation(() => {})
        // Act
        const computer = new ComputerDynamicPrototype(ram, hardDisk)
        // Assert
        expect(computer.ram).toBe(ram)
        expect(computer.hardDisk).toBe(hardDisk)
        expect(typeof computer.AvailableMemory).toBe('function')

        consoleSpy.mockRestore()
    })

    it('should call the available memory method and check console output', () => {
        // Arrange
        const ram = '8GB'
        const hardDisk = '256GB SSD'
        const consoleSpy = jest.spyOn(console, 'log').mockImplementation(() => {})
        // Act
        const computer = new ComputerDynamicPrototype(ram, hardDisk)
        computer.AvailableMemory?.()
        // Assert
        expect(consoleSpy).toHaveBeenCalledWith(`\nHarddisk is : ${hardDisk}`)
        expect(consoleSpy).toHaveBeenCalledWith(`Ram is : ${ram}`)
        
        consoleSpy.mockRestore()
    })
})