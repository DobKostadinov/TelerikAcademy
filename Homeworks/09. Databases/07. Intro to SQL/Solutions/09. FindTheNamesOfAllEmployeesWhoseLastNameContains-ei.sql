--Write a SQL query to find the names of all employees whose last name contains "ei".

USE TelerikAcademy

SELECT e.LastName
FROM dbo.Employees e
WHERE e.LastName LIKE '%ei%'