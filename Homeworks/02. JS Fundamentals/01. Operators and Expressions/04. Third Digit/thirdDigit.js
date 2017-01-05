let numbersAsArray = ['5', '701', '9703', '877', '777877', '9999799'];

for (let i = 0; i < numbersAsArray.length; i++) {
    checkThirdDigit(numbersAsArray[i]);
}

function checkThirdDigit(number) {
    let thirdPosition = number.charAt(number.length - 3);

    if(thirdPosition.toString() === '7') {
        console.log(true);
    } else if(number.length < 3){
        console.log(false + ' 0')
    } else {
        console.log("false " + thirdPosition);
    }
}