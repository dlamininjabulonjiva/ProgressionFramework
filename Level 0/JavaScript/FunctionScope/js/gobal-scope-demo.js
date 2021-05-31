// global variables - their lives are available throuhgout the entire page and throuhgout the entire script
const num1 = 15;
const num2 = 10;
let total = 0;

function calculateSum() {
    total = num1 + num2;
    return total;
}

function calculateSquareOfNumOne() {
    total = Math.pow(num1, 2);
    return total;
}

function calculateCubeOfNumTwo() {
    total = Math.pow(num2, 3);
    return total;
}