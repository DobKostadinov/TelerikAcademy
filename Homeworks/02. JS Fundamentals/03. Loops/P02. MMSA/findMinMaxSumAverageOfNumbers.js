let inputTest = [
    ['2', '5', '1'],
    ['2', '-1', '4']
];

for (let i = 0; i < inputTest.length; i++) {
    let numbers = inputTest[i],
        floatNumbersArray = [];

    for (var j = 0; j < numbers.length; j++) {
        floatNumbersArray[j] = parseFloat(numbers[j]);
    }

    findMMSAOfAllNumbers(floatNumbersArray);
}

function findMMSAOfAllNumbers(numbers) {
    let min = Math.min.apply(null, numbers),
        max = Math.max.apply(null, numbers),
        sum = 0,
        avg;

    for(var i = 0; i < numbers.length; i++) {
        sum += numbers[i];
    }

    avg = sum / numbers.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}
