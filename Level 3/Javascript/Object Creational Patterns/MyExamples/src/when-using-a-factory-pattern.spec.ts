interface Computer {
    ram: string;
    hardDisk: string;
    availableMemory(): void;
}
  
const computerFactory = (ram: string, hardDisk: string): Computer => {
    const computer: Computer = {
      ram,
      hardDisk,
      availableMemory: function () {
        console.log('Hard-disk is: ' + this.hardDisk);
        console.log('Ram is: ' + this.ram);
      },
    }
    return computer;
}

describe('computerFactory', () => {
    it('should create a computer with specified ram and hard disk', () => {
        // Arrange
        const ram = '8GB'
        const hardDisk = '256GB SSD'
        // Act
        const computer = computerFactory(ram, hardDisk)
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
        const computer = computerFactory(ram, hardDisk)
        computer.availableMemory()
        // Assert
        expect(consoleSpy).toHaveBeenCalledWith(`Hard-disk is: ${hardDisk}`)
        expect(consoleSpy).toHaveBeenCalledWith(`Ram is: ${ram}`)

        consoleSpy.mockRestore()
    })
})