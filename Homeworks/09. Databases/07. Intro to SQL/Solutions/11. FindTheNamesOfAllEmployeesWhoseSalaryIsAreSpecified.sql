--Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM dbo.Employees e 
WHERE e.Salary IN (25000, 14000, 12500, 23600)