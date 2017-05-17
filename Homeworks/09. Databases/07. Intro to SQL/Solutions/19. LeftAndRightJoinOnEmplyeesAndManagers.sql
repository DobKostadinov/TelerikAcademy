/*Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager.
  Use right outer join. Rewrite the query to use left outer join.*/

USE TelerikAcademy

--RIGHT JOIN
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   m.FirstName + ' ' + m.LastName AS [Manager Full Name]
FROM dbo.Employees e
RIGHT JOIN dbo.Employees m
ON e.ManagerID = m.ManagerID

--LEFT JOIN
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   m.FirstName + ' ' + m.LastName AS [Manager Full Name]
FROM dbo.Employees e
LEFT JOIN dbo.Employees m
ON e.ManagerID = m.ManagerID