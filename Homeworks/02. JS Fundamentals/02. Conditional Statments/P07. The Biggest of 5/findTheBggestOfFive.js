let inputTestNumbers = [
    ['5', '2', '2', '4', '1'],
    ['-2', '-22', '1', '0', '0'],
    ['-2', '4', '3', '2', '0'],
    ['0', '-2.5', '0', '5', '5'],
    ['-3', '-0.5', '-1.1', '-2', '-0.1']
];

for (let i = 0; i < inputTestNumbers.length; i++) {
    let crrNumbers = inputTestNumbers[i];

    findBiggestAmongFiveNumbers(crrNumbers);
}

function findBiggestAmongFiveNumbers(args){
    let a = +args[0],
        b = +args[1],
        c = +args[2],
        d = +args[3],
        e = +args[4];

    let max  = a;

    if (b > max) {
        max = b;
    }

    if (c > max) {
        max = c;
    }

    if (d > max) {
        max = d;
    }

    if (e > max) {
        max = e;
    }

    console.log(max);
}