let numbersAsArray = ['15', '1024'];

for (let i = 0; i < numbersAsArray.length; i++) {
    thirdBit(+numbersAsArray[i]);
}

function thirdBit(num) {
    var b = (num >>> 3).toString(2) + "";

    console.log(b[b.length - 1]);
}