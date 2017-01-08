let inputTestNumbers = [
    ['5', '2', '2'],
    ['-2', '-2', '1'],
    ['-2', '4', '3'],
    ['0', '-2.5', '5'],
    ['-0.1', '-0.5', '-1.1']
];

for (let i = 0; i < inputTestNumbers.length; i++) {
    let crrNumbers = inputTestNumbers[i];

    SortTheNumbers(crrNumbers);
}

function SortTheNumbers(numbers) {
    let a = +numbers[0],
        b = +numbers[1],
        c = +numbers[2];

    let max = Math.max(a,b,c);

    console.log(max);
}