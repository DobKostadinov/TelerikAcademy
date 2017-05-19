/*
03. Write a SQL query to find the full name, salary and department of the employees that take 
    the minimal salary in their department
*/

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name],
	   e.Salary,
	   d.Name [Department Name]
FROM Employees e
JOIN Departments d 
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
	(SELECT MIN(en.Salary) 
	FROM Employees en 
	WHERE en.DepartmentID = d.DepartmentID)
ORDER BY e.Salary