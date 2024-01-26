class Computer {
    ram: string;
    hardDisk: string;
  
    constructor(ram: string, hardDisk: string) {
      this.ram = ram;
      this.hardDisk = hardDisk;
    }
  
    availableMemory(): void {
      console.log('Hard-disk is: ' + this.hardDisk);
      console.log('Ram is: ' + this.ram);
    }
}

describe('computerClass', () => {
    it('should create a computer with specified ram and hard disk', () => {
        // Arrange
        const ram = '8GB'
        const hardDisk = '256GB SSD'
        // Act
        const computer = new Computer(ram, hardDisk)
        // Assert
        expect(computer.ram).toBe(ram)
        expect(computer.hardDisk).toBe('256GB SSD')
    })
  
    it('should print out the ram and hard disk information when availableMemory method is called', () => {
        // Arrange
        const ram = '16GB'
        const hardDisk = '1TB HDD'
        const consoleSpy = jest.spyOn(console, 'log').mockImplementation(() => {})
        // Act
        const computer = new Computer(ram, hardDisk)
        computer.availableMemory()
        // Assert
        expect(consoleSpy).toHaveBeenCalledWith(`Hard-disk is: ${hardDisk}`)
        expect(consoleSpy).toHaveBeenCalledWith(`Ram is: ${ram}`)

        consoleSpy.mockRestore()
    })
})