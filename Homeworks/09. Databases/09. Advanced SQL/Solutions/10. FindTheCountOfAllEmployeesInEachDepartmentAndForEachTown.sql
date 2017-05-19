/*
10. Write a SQL query to find the count of all employees in each department and for each town.
*/

USE TelerikAcademy

SELECT COUNT(*) AS [Number of employees],
	   d.Name AS [Department],
	   t.Name AS [Town]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
JOIN Addresses a 
	ON e.AddressID = a.AddressID
JOIN Towns t 
	ON a.TownID = t.TownID
GROUP BY d.Name,
		 t.Name