--Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM dbo.Employees e 
WHERE e.Salary > 50000
ORDER BY e.Salary DESC