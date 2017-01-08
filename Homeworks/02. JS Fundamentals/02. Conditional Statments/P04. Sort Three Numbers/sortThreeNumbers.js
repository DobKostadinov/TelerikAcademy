let inputTestNumbers = [
    ['5', '1', '2'],
    ['-2', '-2', '1'],
    ['-2', '4', '3'],
    ['0', '-2.5', '5'],
    ['-1.1', '-0.5', '-0.1'],
    ['10', '20', '30'],
    ['1', '1', '1']
];

for (let i = 0; i < inputTestNumbers.length; i++) {
    let crrNumbers = inputTestNumbers[i];

    console.log(SortTheNumbers(crrNumbers));
}

function SortTheNumbers(numbers) {
    var a = +numbers[0],
        b = +numbers[1],
        c = +numbers[2];

    if (a >= b && a >= c) {
        if (b >= c) {
            return a + ' ' + b + ' ' + c;
        } else {
            return a + ' ' + c + ' ' + b;
        }
    } else if (b >= a && b >= c) {
        if (a >= c) {
            return b + ' ' + a + ' ' + c;
        } else {
            return b + ' ' + c + ' ' + a;

        }
    } else if (c >= a && c >= b) {
        if (a >= b) {
            return c + ' ' + a + ' ' + b;
        } else {
            return c + ' ' + b + ' ' + a;
        }
    }
}