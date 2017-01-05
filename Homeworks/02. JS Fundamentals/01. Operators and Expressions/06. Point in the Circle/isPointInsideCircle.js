let parameters =
    [['-2', '0'],
        ['-1', '2'],
        ['1.5', '-1'],
        ['-1.5', '-1.5'],
        ['100', '-30'],
        ['0', '0'],
        ['0.2', '-0.8'],
        ['0.9', '-1.93'],
        ['1', '1.655'],
        ['0', '1']];

for (let i = 0; i < parameters.length; i++) {
    let currParams = parameters[i];

   isPointInsideCircle(currParams);
}

function isPointInsideCircle(params) {
    let x = +params[0],
        y = +params[1],
        r = 2,
        distance = Math.sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0)).toFixed(2);

    if(distance <= r){
        console.log('yes ' + distance);
    } else {
        console.log('no ' + distance);
    }
}