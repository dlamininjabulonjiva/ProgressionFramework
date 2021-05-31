function calculateExamPercent(totalMarksObtained, totalExamMarks) {
    if (typeof totalMarksObtained === "number" && typeof totalExamMarks === "number"){
        const finalMarkPercent = (totalMarksObtained / totalExamMarks) * 100
        return finalMarkPercent;
    }

    return 0;
}

function calculateStudentFinalMarkAndReturnStatus(studentDPMark, studentExamMark){
    const dpMark = typeof studentDPMark === "number" ? studentDPMark / 2 : 0;
    const examMark = typeof studentExamMark === "number" ? studentExamMark / 2 : 0;

    const finalMark = dpMark + examMark;
    let status = "";

    if (finalMark >= 75){
        status = "Passed Distinction";
    }

    if (finalMark >= 50 && finalMark < 75){
        status = "Passed";
    }

    if (finalMark == 49){
        status = "Condoned Pass";
    }

    if (finalMark >= 40 && finalMark <= 48){
        status = "Supplementary";
    }

    if (finalMark <= 39){
        status = "Failed";
    }

    return status;
}

function getNumberOfMaleStudents(studentList) {
    const students = typeof studentList === "object" ? studentList : [];
    const numberOfMaleStudents = students.filter(s => s.gender === 'Male').length;
    return numberOfMaleStudents;
}