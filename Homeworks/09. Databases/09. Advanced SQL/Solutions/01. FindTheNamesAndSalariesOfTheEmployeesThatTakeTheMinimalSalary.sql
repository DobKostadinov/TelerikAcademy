/*
01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
Use a nested SELECT statement.
*/

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName [Full Name], e.Salary
FROM Employees e
WHERE e.Salary = 
	(SELECT MIN(en.Salary) 
	FROM Employees en)