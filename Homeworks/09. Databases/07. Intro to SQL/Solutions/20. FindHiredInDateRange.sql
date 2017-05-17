/*Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose 
hire year is between 1995 and 2005.*/

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   d.Name AS [Department Name],
	   FORMAT(e.HireDate,'yyyy-MM-dd') AS [Hire Date]
FROM dbo.Employees e, dbo.Departments d
WHERE d.Name IN ('Sales', 'Finance')
AND e.HireDate BETWEEN '1995-01-01' AND '2005/01/01'
