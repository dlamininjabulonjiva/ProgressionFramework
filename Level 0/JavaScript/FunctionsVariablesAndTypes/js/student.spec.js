describe('Student', () =>{
    it('given invalid number should return 0 as the exam percent obtained by a student', () => {
		// Arrange
		const totalMarksObtained = 120;
        const totalExamMarks = "200";
		const expected = 0;
		// Act
		var actual = calculateExamPercent(totalMarksObtained, totalExamMarks);
		// Assert
		expect(actual).toBe(expected);
	});

    it('should calculate the exam percent obtained by a student', () => {
		// Arrange
		const totalMarksObtained = 120;
        const totalExamMarks = 200;
		const expected = 60;
		// Act
		var actual = calculateExamPercent(totalMarksObtained, totalExamMarks);
		// Assert
		expect(actual).toBe(expected);
	});

    it('should calculate student total mark and return status(Passed Distinction)', () => {
		// Arrange
		const studentDPMark = 80;
		const studentExamMark = 85;
		const expected = "Passed Distinction";
		// Act
		var actual = calculateStudentFinalMarkAndReturnStatus(studentDPMark, studentExamMark);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate student total mark and return status(Passed)', () => {
		// Arrange
		const studentDPMark = 75;
		const studentExamMark = 55;
		const expected = "Passed";
		// Act
		var actual = calculateStudentFinalMarkAndReturnStatus(studentDPMark, studentExamMark);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate student total mark and return status(Condoned Pass)', () => {
		// Arrange
		const studentDPMark = 49;
		const studentExamMark = 49;
		const expected = "Condoned Pass";
		// Act
		var actual = calculateStudentFinalMarkAndReturnStatus(studentDPMark, studentExamMark);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate student total mark and return status(Supplementary)', () => {
		// Arrange
		const studentDPMark = 42;
		const studentExamMark = 45;
		const expected = "Supplementary";
		// Act
		var actual = calculateStudentFinalMarkAndReturnStatus(studentDPMark, studentExamMark);
		// Assert
		expect(actual).toBe(expected);
	});

	it('should calculate student total mark and return status(Failed)', () => {
		// Arrange
		const studentDPMark = 42;
		const studentExamMark = 25;
		const expected = "Failed";
		// Act
		var actual = calculateStudentFinalMarkAndReturnStatus(studentDPMark, studentExamMark);
		// Assert
		expect(actual).toBe(expected);
	});

    it('should return the number of male students', () => {
		// Arrange
		const studentList = [
            { name: 'Frank', gender: 'Male' },
            { name: 'Sarah', gender: 'Female' },
            { name: 'Michael', gender: 'Male' },
            { name: 'Jessy', gender: 'Female' },
            { name: 'David', gender: 'Male' },
            { name: 'Jabari', gender: 'Male' },
        ];
        const expected = 4;
		// Act
		var actual = getNumberOfMaleStudents(studentList);
		// Assert
		expect(actual).toBe(expected);
	});
});