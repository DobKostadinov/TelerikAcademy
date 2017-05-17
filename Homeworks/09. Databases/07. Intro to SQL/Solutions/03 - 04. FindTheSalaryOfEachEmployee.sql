--Write a SQL to find the full name of each employee and their salary.

USE TelerikAcademy	

SELECT e.FirstName + ' ' + e.LastName As [Full Name], e.Salary 
FROM dbo.Employees e
