/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve() {
	  return function sum(numbers) {
		  
		numbers.forEach(function checkIfNumber (x) {
			if(Number.isNaN(Number(x))) {
				throw 'All values should be of type Number!';
			}
		});

		if(numbers.length === 0) {
			return null;
		}

		if(!numbers) {
			throw 'Parameter is not passed!';
		}

		let sum = numbers.reduce((a, b) => a + (+b), 0);

		return sum;
	}
}

module.exports = solve;
