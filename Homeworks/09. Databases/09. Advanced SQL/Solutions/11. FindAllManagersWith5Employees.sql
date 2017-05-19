/*
11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
*/

USE TelerikAcademy

SELECT m.FirstName,
	   m.LastName
FROM Employees m
	JOIN Employees e
	ON e.ManagerID = m.ManagerID
GROUP BY m.FirstName,
		 m.LastName,
		 m.ManagerID
HAVING COUNT(e.EmployeeID) = 5