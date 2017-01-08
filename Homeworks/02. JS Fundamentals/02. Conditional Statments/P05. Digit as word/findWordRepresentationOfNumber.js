let input = [
    ['2'],
    ['1'],
    ['0'],
    ['5'],
    ['-0.1'],
    ['hi'],
    ['9'],
    ['10']
];

for (let i = 0; i < input.length; i++) {
    let crrNumbers= input[i];

    findWordRepresentationOfNumber(crrNumbers)
}

function findWordRepresentationOfNumber(number) {
    var num = +number[0];

    switch(num){
        case 0:
            return console.log('zero');
        case 1:
            return console.log('one');
        case 2:
            return console.log('two');
        case 3:
            return console.log('three');
        case 4:
            return console.log('four');
        case 5:
            return console.log('five');
        case 6:
            return console.log('six');
        case 7:
            return console.log('seven');
        case 8:
            return console.log('eight');
        case 9:
            return console.log('nine');
        default:
            return console.log('not a digit');
    }
}