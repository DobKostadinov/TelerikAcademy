/*
02. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
*/

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM Employees e
WHERE e.Salary > 
	(SELECT MIN(en.Salary) * 1.1 
	FROM Employees en)
ORDER BY e.Salary