let numbersAsArray = ['3', '0', '5', '7', '35', '140'];

for (let i = 0; i < numbersAsArray.length; i++) {
    isDivisibleBy7and5(+numbersAsArray[i]);
}

function isDivisibleBy7and5(num) {
    if ((num % 5 === 0) && (num % 7 === 0)) {
        console.log('true ' + num);
    } else {
        console.log('false ' + num);
    }
}

