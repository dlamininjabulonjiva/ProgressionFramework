function incrementCurrentAgeByValue(number) {
    let currentAge = 20;
    function increment() { currentAge += number; }
    increment();
    return currentAge;
}

var incrementCounter = (function () {
    let counter = 0;
    return function () {
        counter += 1; 
        return counter;
    }
})();

function doMultiplication(num1) {
    return function (num2) {
        return num1 * num2;
    }
}

const number = 10;
function calculateTotal(num1){
  return function(num2){
    return function(num3){
      return function(num4){
        return num1 + num2 + num3 + num4 + number;
      }
    }
  }
}