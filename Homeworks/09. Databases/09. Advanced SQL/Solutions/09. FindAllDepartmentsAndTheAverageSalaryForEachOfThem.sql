/*
09. Write a SQL query to find all departments and the average salary for each of them.
*/

USE TelerikAcademy

SELECT AVG(e.Salary) AS [Average Salary],
	   d.Name AS [Department Name]	
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID
GROUP BY d.Name