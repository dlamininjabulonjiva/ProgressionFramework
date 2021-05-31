function calculateNumberOfCharacters(input) {
    // local variable - can only be accessed from within the function
    const strInput = input;
    return strInput.length;
}

function calculateTheSquareOfTheSum() {
    // local variables - can only be accessed from within the function
    const num1 = 20;
    const num2 = 25;
    let square = 0;

    const sum = num1 + num2;
    square = Math.pow(sum, 2);
    return square;
}