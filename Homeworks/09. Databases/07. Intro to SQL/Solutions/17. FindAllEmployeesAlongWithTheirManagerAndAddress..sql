--Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   m.FirstName + ' ' + m.LastName AS [Manager Full Name],
	   a.AddressText AS [Address]
FROM dbo.Employees e, dbo.Employees m, dbo.Addresses a
WHERE e.ManagerID = m.ManagerID 
AND e.AddressID = a.AddressID