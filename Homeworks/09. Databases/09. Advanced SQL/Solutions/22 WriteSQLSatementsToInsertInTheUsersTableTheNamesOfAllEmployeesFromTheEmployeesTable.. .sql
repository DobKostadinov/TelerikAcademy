/*
22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
- Combine the first and last names as a full name.
- For username use the first letter of the first name + the last name (in lowercase).
- Use the same for the password, and NULL for last login time.
*/

INSERT INTO Users(Username, [Password], FullName, LastLogTime)
SELECT LOWER(RIGHT(e.FirstName, 5) + LEFT(e.LastName, 5)),
	   LOWER(RIGHT(e.FirstName, 3) + LEFT(e.LastName, 4)),
	   e.FirstName + ' ' + e.LastName,
	   NULL
 FROM Employees e