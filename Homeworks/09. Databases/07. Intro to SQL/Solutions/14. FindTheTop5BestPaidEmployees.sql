--Write a SQL query to find the top 5 best paid employees.

USE TelerikAcademy

SELECT TOP 5 e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM dbo.Employees e 
ORDER BY e.Salary DESC
