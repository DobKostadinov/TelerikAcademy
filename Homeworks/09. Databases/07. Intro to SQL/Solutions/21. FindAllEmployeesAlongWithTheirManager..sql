--Write a SQL query to find all employees along with their manager.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   m.FirstName + ' ' + m.LastName AS [Manager Full Name]
FROM dbo.Employees e, dbo.Employees m
WHERE e.ManagerID = m.ManagerID