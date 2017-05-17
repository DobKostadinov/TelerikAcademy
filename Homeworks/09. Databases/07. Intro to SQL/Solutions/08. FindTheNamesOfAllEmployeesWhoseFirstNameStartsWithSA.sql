--Write a SQL query to find the names of all employees whose first name starts with "SA".

USE TelerikAcademy

SELECT e.FirstName
FROM dbo.Employees e
WHERE e.FirsTName LIKE 'SA%'
