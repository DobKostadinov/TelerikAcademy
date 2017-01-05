let parameters =
    [['5', '7', '12'],
        ['2', '1', '33'],
        ['8.5', '4.3', '2.7'],
        ['100', '200', '300'],
        ['0.222', '0.333', '0.555']];

for (let i = 0; i < parameters.length; i++) {
    let currParams = parameters[i];

    findTrapezoidArea(currParams);
}

function findTrapezoidArea(params) {
    let a = +params[0],
        b = +params[1],
        h = +params[2],
        area = ((a + b) / 2) * h;

    console.log(area.toFixed(7));
}