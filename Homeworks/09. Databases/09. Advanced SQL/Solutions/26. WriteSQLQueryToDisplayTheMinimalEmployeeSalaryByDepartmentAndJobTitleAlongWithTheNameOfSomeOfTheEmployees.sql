/*
26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
*/

SELECT  MIN(e.FirstName + ' ' + e.LastName) AS [Full Name],
		MIN(e.Salary) AS [Minimal Salary],
	    d.Name AS [Department Name],
	    e.JobTitle AS [Job Title]
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
    GROUP BY d.Name, e.JobTitle

