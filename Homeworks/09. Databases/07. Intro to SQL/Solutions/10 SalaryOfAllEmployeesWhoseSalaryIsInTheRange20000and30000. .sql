--Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM dbo.Employees e 
WHERE e.Salary BETWEEN 20000 AND 30000