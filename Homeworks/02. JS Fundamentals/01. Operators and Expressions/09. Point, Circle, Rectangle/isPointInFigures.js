let parameters =
    [['2.5', '2'],
        ['0', '1'],
        ['2.5', '1'],
        ['1', '2']];

for (let i = 0; i < parameters.length; i++) {
    let currParams = parameters[i];

    isPointInFigures(currParams);
}

function isPointInFigures(params) {
    let x = +params[0],
        y = +params[1],
        circleR = 1.5,
        result = '',
        distance = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));

    if(distance <= circleR){
        result = "inside circle";
    } else {
        result = "outside circle";
    }

    if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
    {
        result += " inside rectangle";
    }
    else
    {
        result += " outside rectangle";
    }

    console.log(result);
}