let testInputs = [
    ['2'],
    ['3'],
    ['4']
];

for (let i = 0; i < testInputs.length; i++) {
    let upperLimit = +testInputs[i];

    printMatrix(upperLimit);
}

function printMatrix(upperLimit) {
    let resultLine;

    for (let row = 1; row <= upperLimit; row++) {
        resultLine = '';

        for (let col = row; col < upperLimit + row; col++) {
            resultLine += col + ' ';
        }

        console.log(resultLine);
    }

    console.log('---------')
}