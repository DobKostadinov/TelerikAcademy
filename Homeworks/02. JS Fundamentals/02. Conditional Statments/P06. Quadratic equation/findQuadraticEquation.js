let inputTestNumbers = [
    ['2', '5', '-3'],
    ['-1', '3', '0'],
    ['-0.5', '4', '-8'],
    ['5', '2', '8'],
    ['0.2', '9.572', '0.2']
];

for (let i = 0; i < inputTestNumbers.length; i++) {
    let crrNumbers = inputTestNumbers[i];

    findQuadraticEquation(crrNumbers);
}

function findQuadraticEquation(numbers) {
    let a = +numbers[0],
        b = +numbers[1],
        c = +numbers[2],
        temp;

    let d = (b * b) - (4 * a * c);

    if (d < 0) {
        console.log("no real roots");
    } else if (d === 0) {
        let output = -b / (2 * a);
        console.log('x1=x2='+ output.toFixed(2));
    } else if (d > 0) {
        let sqrtD = Math.sqrt(d);

        let output1 = (-b + sqrtD) / (2 * a);
        let output2 = (-b - sqrtD) / (2 * a);

        if (output2 < output1) {
            temp = output1;
            output1 = output2;
            output2 = temp;
        }

        console.log('x1=' + output1.toFixed(2) + "; x2=" + output2.toFixed(2));
    }
}