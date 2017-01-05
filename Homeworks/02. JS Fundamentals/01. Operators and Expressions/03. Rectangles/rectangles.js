let parameters =
    [['2.5', '3'],
        ['5', '5'],
        ['3', '4']];

for (let i = 0; i < parameters.length; i++) {
    let currParams = parameters[i];

    for (let j = 0; j < currParams.length - 1; j++) {
        let width = +currParams[j],
            height = +currParams[j + 1];

        let area = width * height,
            perimeter = 2 * (width + height);

        console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
    }
}