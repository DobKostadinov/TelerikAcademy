let testInputs = [
    ['FE'],
    ['1AE3'],
    ['4ED528CBB4']
];

for (let i = 0; i < testInputs.length; i++) {
    let hexValue = testInputs[i];

    convertHexToDec(hexValue);
}

function convertHexToDec(args) {
    let hex = args[0],
        res = 0,
        sixTeen = 1;

    for (let i = hex.length - 1; i >= 0; i-=1) {
        let currentCh = hex[i];
        if (+currentCh >= 0 && +currentCh < 10) {
            res += +currentCh * sixTeen;
            sixTeen *= 16;
        } else if (currentCh == 'A') {
            res += 10 * sixTeen;
            sixTeen *= 16;
        } else if (currentCh == 'B') {
            res += 11 * sixTeen;
            sixTeen *= 16;
        } else if (currentCh == 'C') {
            res += 12 * sixTeen;
            sixTeen *= 16;
        } else if (currentCh == 'D') {
            res += 13 * sixTeen;
            sixTeen *= 16;
        } else if (currentCh == 'E') {
            res += 14 * sixTeen;
            sixTeen *= 16;
        } else if (currentCh == 'F') {
            res += 15 * sixTeen;
            sixTeen *= 16;
        }
    }
    console.log(res);
}