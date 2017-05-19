/*
12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
*/

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Employee name],
	   ISNULL(m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager name] 
FROM Employees e
LEFT JOIN Employees m 
	ON e.ManagerID = m.ManagerID