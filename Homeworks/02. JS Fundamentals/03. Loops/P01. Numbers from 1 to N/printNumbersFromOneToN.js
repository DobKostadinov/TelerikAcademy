let testInputs = [
    ['5'],
    ['1']
];

for (let i = 0; i < testInputs.length; i++) {
    let upperLimit = +testInputs[i];

    printNumbersInRange(upperLimit);
}

function printNumbersInRange(upperLimit) {
    let result = '';

    for (let i = 1; i <= upperLimit; i++) {
        if(i === upperLimit){
            result += i;
        } else {
            result += i + ' ';
        }
    }

    console.log(result);
}