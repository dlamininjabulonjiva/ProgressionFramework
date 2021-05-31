const operators = {
    Add: 0, 
    Subtract: 1, 
    Multiply: 2,
    Divide: 3,
}

function calculationFor(num1, num2, operator) {
    let result = null;

    if (typeof num1 === "number" && typeof num2 === "number" && typeof operator === "number"){
        switch (operator) {
            case operators.Add:
                result = num1 + num2;
                break
            case operators.Subtract:
                result = num1 - num2;
                break
            case operators.Multiply:
                result = num1 * num2;
                break
            case operators.Divide:
                result = num1 / num2;
                break
        }
    }
    
    return this.isNull(result) ? 0 : isNaN(result) ? 0 : result;
}

function isNull(value) {
    return value === null;
}