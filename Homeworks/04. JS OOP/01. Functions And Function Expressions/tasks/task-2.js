/* Task description */
/*
 Write a function that finds all the prime numbers in a range
	1) it should return the prime numbers in an array
	2) it must throw an Error if any on the range params is not convertible to `Number`
	3) it must throw an Error if any of the range params is missing
 */

function solve() {
     return function findPrimes(a, b) {

         var firstNumber,
             secondNumber,
             i,
             j,
             isPrime = false,
             arrOfPrimeNumbers = [];

        if ((a === undefined) || (b === undefined)) {
            throw 'Ranges are not passed!';
        }

       try {
           firstNumber = +a;
           secondNumber = +b;
       } catch (err) {
           throw 'Error';
       }

        for (i = firstNumber; i <= secondNumber; i++) {
            for (j = 2; j < i; j++) {
                if (i % j === 0) {
                    isPrime = false;
                }
            }

            if (isPrime && i !== 1 && i !== 0) {
                arrOfPrimeNumbers.push(i);
            }

            isPrime = true;
        }

        return arrOfPrimeNumbers;
    }
}

