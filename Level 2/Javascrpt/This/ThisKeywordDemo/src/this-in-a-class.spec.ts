// class Employee {
//     updatedDate: Date
//     previousValue: string
  
//     constructor(private employeeId: string) {}
  
//     get employeeIdNumber() {
//       return this.employeeId
//     }
  
//     get priorValue() {
//       return this.previousValue
//     }
  
//     updateEmployeeId(employeeId: string) {
//       this.storeAuditData()
//       this.employeeId = employeeId
//     }
  
//     private storeAuditData() {
//       this.updatedDate = new Date()
//       this.previousValue = this.employeeId
//     }
// }
  
// describe('this in a class', () => {
//     it('can be used to refer to fields on the class', () => {
//       // Arrange
//       const employeeId = 'EMP123'
//       // Act
//       const employee = new Employee(employeeId)
//       // Assert
//       expect(employee.employeeIdNumber).toEqual(employeeId)
//     })
  
//     it('can be used to refer to functions on the class', () => {
//       // Arrange
//       const employeeId1 = 'EMP123'
//       const employeeId2 = 'EMP456'
//       const employee = new Employee(employeeId1)
//       // Act
//       employee.updateEmployeeId(employeeId2)
//       // Assert
//       expect(employee.employeeIdNumber).toEqual(employeeId2)
//       expect(employee.previousValue).toEqual(employeeId1)
//     })
// })