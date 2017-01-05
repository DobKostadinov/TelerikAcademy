let numbersAsArray = ['3', '2', '-2', '-1', '0'];

for (let i = 0; i < numbersAsArray.length; i++) {
    isOddOrEven(+numbersAsArray[i]);
}

function isOddOrEven(number) {
    if (number % 2 === 0) {
        console.log('even ' + number);
    } else {
        console.log('odd ' + number);
    }
}
