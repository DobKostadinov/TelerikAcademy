/*
28.  Write a SQL query to display the number of managers from each town.
*/

SELECT COUNT(DISTINCT m.ManagerID) AS [Number of managers],
	   t.Name AS [Town]
FROM Employees e
	JOIN Employees m
	ON e.ManagerID = m.ManagerID
	JOIN Addresses a
	ON a.AddressID = m.AddressID
	JOIN Towns t
	ON t.TownID = a.TownID
GROUP BY t.Name