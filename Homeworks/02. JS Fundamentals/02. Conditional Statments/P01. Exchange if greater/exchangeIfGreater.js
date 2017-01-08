let inputTestNumbers = [
    ['5', '2'],
    ['3', '4'],
    ['5.5', '4.5']
];

for (let i = 0; i < inputTestNumbers.length; i++) {
    let crrNumbers = inputTestNumbers[i];

    exchangeIfGreater(crrNumbers);
}

function exchangeIfGreater(numbers) {
    let firstNum = +numbers[0],
        secondNum = + numbers[1],
        temp;

    if(firstNum > secondNum) {
        temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
    }

    console.log(firstNum + ' ' + secondNum);
}

