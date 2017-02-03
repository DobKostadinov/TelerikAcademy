function solve() {
	var Course = {
		init: function(title, presentations) {

			this.presentations = [];
			this.students = [];

			validateTitles(title);

			validatePresentationArray(presentations);

			for (let i = 0; i < presentations.length; i++) {
				validateTitles(presentations[i]);

				let presentation = {
					id : i + 1,
					title : presentations[i],
					homeworks : []
				};

				this.presentations.push(presentation);
			}

			//Validations
			function validateTitles(title) {
				if(!title) {
					throw 'Title cannot be empty!';
				} else if (/^\s{1,}/.test(title)) {
					throw 'Title cannot start with an empty space!';
				} else if(/\s{1,}$/.test(title)) {
					throw 'Title cannot end with an empty space!';
				} else if (/\s{2,}/.test(title)) {
					throw 'Title cannot consist consecutive spaces!';
				} else if(title.length < 2) {
					throw 'Title should be at least one char!';
				}
			}
			
			function validatePresentationArray(presentations) {
				if(!presentations) {
					throw 'Presentations should be passed!';
				}

				if (presentations.length < 1) {
					throw Error('There are no presentations');
				}
			}

			return this;
		},

		addStudent: function(name) {

			validateFullNameInput(name);

			let names = name.split(' ');

			validateLengthOfFullName(names);

			for (let i = 0; i < names.length; i++) {
				validateEachNameInFullName(names[i]);
			}

			let student = {
				firstname : names[0],
				lastname : names[1],
				id : this.students.length + 1
			};

			this.students.push(student);

			return student.id;



			//Validations

			function validateFullNameInput(name) {
				if(!name) {
					throw 'Student name should be passed!';
				} else if(typeof name !== 'string') {
					throw 'Student name should be string!';
				}
			}

			function validateLengthOfFullName(fullNameAsArray) {
				if(fullNameAsArray.length > 2) {
					throw 'Full name should not be more than 2 names!';
				} else if(fullNameAsArray.length < 2) {
					throw 'Full name should not be less than 2 names!';
				}
			}
			
			function validateEachNameInFullName(name) {
				if(!name) {
					throw 'Name is empty!';
				}

				var firstNameChar = name[0],
					restOfName = name.slice(1);

				if (firstNameChar !== firstNameChar.toUpperCase()) {
					throw 'Name cannot start with upper case!';
				} else if (restOfName !== restOfName.toLowerCase()) {
					throw 'Name should contain only lowercase characters!';
				}
			}
		},

		getAllStudents: function() {
			return this.students.slice();

		},

		submitHomework: function(studentID, homeworkID) {
			validateIds(studentID);
			validateIds(homeworkID);

			let studentsLength = this.students.length,
				homeworksLength = this.presentations.length;

			validateStudentId(studentID, studentsLength);
			validateHomeworkId(homeworkID, homeworksLength);


			//Validations
			function validateIds(id) {
				if(isNaN(id)) {
					throw 'Id should be number!';
				} else if(!isInt(id)) {
					throw 'Id should be an integer!';
				} else if (id < 1) {
					throw 'Id cannot be less than 1!';
				}
			}
			
			function validateStudentId(studentId, studentsLength) {
				if(studentId > studentsLength) {
					throw 'Invalid student id!';
				}
			}

			function validateHomeworkId(homeworkId, homeworksLength) {

				if(homeworkId > homeworksLength) {
					throw 'Invalid homework id!';
				}
			}

			function isInt(num){
				return Number(num) === num && num % 1 === 0;
			}
		},

		pushExamResults: function(results) {
			if(!results) {
				throw 'Results should be passed!';
			}

			if(!Array.isArray(results)) {
				throw 'Passed value should be an array!';
			}

			let studentsLength = this.students.length,
				allStudentsIds = [];

			for (let i = 0; i < results.length; i++) {
				let studId = results[i]['StudentID'],
					studScore = results[i]['score'];

				validateStudentId(studId, studentsLength);
				validateScore(studScore);

				allStudentsIds.push(studId);
			}

			validateIfDuplicateIDs(allStudentsIds);

			//Validations
			function validateScore(score) {
				if(!score) {
					throw 'Score should be passed!';
				}
				if(isNaN(score)) {
					throw 'Score should be number!';
				}
			}

			function validateStudentId(studentId, studentsLength) {
				if(isNaN(studentId)) {
					throw 'Id should be number!';
				} else if (studentId < 1) {
					throw 'Id cannot be less than 1!';
				} else if (studentId > studentsLength) {
					throw 'Invalid id!';
				}
			}

			function validateIfDuplicateIDs(arrOfStudentIds) {

				let uniqueIds = new Set(arrOfStudentIds);

				if(uniqueIds.size !== arrOfStudentIds.length) {
					throw 'Duplicate Ids!';
				}
			}
		}
	};

	return Course;
}