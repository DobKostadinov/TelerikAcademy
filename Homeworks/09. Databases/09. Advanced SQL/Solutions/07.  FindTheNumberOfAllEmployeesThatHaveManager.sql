/*
07. Write a SQL query to find the number of all employees that have manager.
*/

USE TelerikAcademy

SELECT COUNT(*) AS [Number of Employees with manager]
FROM Employees e
WHERE e.ManagerID IS NOT NULL