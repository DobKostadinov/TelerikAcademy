let numbersAsArray = ['2', '23', '-3', '0', '1'];

for (let i = 0; i < numbersAsArray.length; i++) {
    console.log(isPrime(+numbersAsArray[i]));
}

function isPrime(num) {
    for(let i = 2; i < num; i++) {
        if(num % i === 0) {
            return false;
        }
    }

    return num > 1;
}