function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function addBook(book) {
            if (!book) {
                throw 'Book should be passed!';
            }

            if (checkIfBookIsbnAlreadyExist(book.isbn)) {
                throw 'Book isbn already exists'
            }

            if (!checkIfBookTitleAlreadyExist(book.title)) {
                throw 'Book title already exists!';
            }

            if (!checkIfAllPropertiesOfBookArePassed(book)) {
                throw 'Obligatory properties of book are missing!';
            }

            if (!checkIfBookTitleOrCategoryNameAreValid(book.title)) {
                throw 'Book title should be between 2 and 100 characters!';
            }

            if (!checkIfStringIsEmpty(book.author)) {
                throw 'Book author should not be empty!';
            }

            if (!checkIfIsbnIsValid(book.isbn)) {
                throw 'Book isbn should consist only digits and its length should be 10 or 13 long!'
            }

            if (book.category !== undefined) {
                if (!checkIfBookTitleOrCategoryNameAreValid(book.category)) {
                    throw 'Category name should be between 2 and 100 characters!';
                } else {
                    if (!checkIfBookCategoryAlreadyExist(book.category)) {
                        categories.push(book.category);
                    }
                }
            }


            // Validations
            function checkIfAllPropertiesOfBookArePassed(book) {
                if (book.title === undefined ||
                    book.author === undefined ||
                    book.isbn === undefined) {
                    return false;
                }

                return true;
            }

            function checkIfBookTitleOrCategoryNameAreValid(name) {
                if ((name.length < 2) || (name.length > 100)) {
                    return false;
                }

                return true;
            }

            function checkIfStringIsEmpty(value) {
                if (value === '' || value === null) {
                    return false;
                }

                return true;
            }

            function checkIfIsbnIsValid(bookisbn) {
                var isNumber = false;

                if (!isNaN(Number(bookisbn))) {
                    isNumber = true;
                }

                if (isNumber &&
                    ((bookisbn.toString().length === 10) ||
                    (bookisbn.toString().length === 13))) {
                    return true;
                }

                return false;
            }

            function checkIfBookTitleAlreadyExist(bookTitle) {
                var booksLength = books.length;

                for (var i = 0; i < booksLength; i++) {
                    if (books[i].title === bookTitle) {
                        return false;
                    }
                }

                return true;
            }

            function checkIfBookIsbnAlreadyExist(bookIsbn) {
                var booksLength = books.length;

                for (var i = 0; i < booksLength; i++) {
                    if (books[i].isbn === bookIsbn) {
                        return true;
                    }
                }

                return false;
            }

            function checkIfBookCategoryAlreadyExist(bookCategory) {
                if (categories.includes(bookCategory)) {
                    return true;
                }

                return false;
            }


            book.ID = books.length + 1;
            books.push(book);

            return book;
        }


        function listBooks() {
            let option = arguments[0];

            if (!option) {
                return books;
            }
            if (option.category) {
                return books.filter((x)=> x.category === option.category);
            }
            if (option.author) {
                return books.filter((x)=> x.author === option.author);
            }

            return books;
        }

        function listCategories() {
            return categories.sort((a, b) => b - a);
        }

        return {
            books: {
                add: addBook,
                list: listBooks
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
