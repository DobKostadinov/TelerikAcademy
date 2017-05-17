--Write a SQL query to find all employees that do not have manager.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.ManagerID
FROM dbo.Employees e 
WHERE e.ManagerID IS NULL