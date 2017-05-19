/*
04. Write a SQL query to find the average salary in the department #1.
*/

USE TelerikAcademy

SELECT AVG(e.Salary) AS [Average Salary] 
FROM Employees e
WHERE e.DepartmentID = 1