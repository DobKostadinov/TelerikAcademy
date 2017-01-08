let inputTestNumbers = [
    ['5', '2', '2'],
    ['-2', '-2', '1'],
    ['-2', '4', '3'],
    ['0', '-2.5', '4'],
    ['-1', '-0.5', '-5.1']
];

for (let i = 0; i < inputTestNumbers.length; i++) {
    let crrNumbers = inputTestNumbers[i];

    findMultiplicationSign(crrNumbers);
}

function findMultiplicationSign(numbers) {
    let counter = 0;

    for(let i = 0; i < numbers.length; i++) {
        if(+numbers[i] < 0) {
            counter++;
        } else if(+numbers[i] === 0) {
            return console.log('0');
        }
    }

    if(counter === 1 || counter === 3) {
        console.log('-');
    } else {
        console.log('+');
    }
}