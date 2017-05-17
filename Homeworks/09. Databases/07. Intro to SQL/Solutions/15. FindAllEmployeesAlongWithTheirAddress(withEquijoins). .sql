--Write a SQL query to find all employees along with their address. Use inner join with ON clause.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], a.AddressText
FROM dbo.Employees e 
	INNER JOIN dbo.Addresses a
	ON e.AddressID = a.AddressID