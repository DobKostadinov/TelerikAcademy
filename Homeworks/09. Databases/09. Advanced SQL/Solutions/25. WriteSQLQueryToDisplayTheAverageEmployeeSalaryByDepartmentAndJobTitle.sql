/*
25. Write a SQL query to display the average employee salary by department and job title.
*/

USE TelerikAcademy

SELECT AVG(e.Salary) AS [Average Salary],
	   d.Name AS [Department Name],
	   e.JobTitle AS [Job Title]
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name, e.JobTitle


