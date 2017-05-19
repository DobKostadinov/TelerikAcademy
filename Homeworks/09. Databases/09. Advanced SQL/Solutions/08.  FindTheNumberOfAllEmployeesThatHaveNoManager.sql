/*
08. Write a SQL query to find the number of all employees that have no manager.
*/

USE TelerikAcademy

SELECT COUNT(*) AS [Number of Employees without manager]
FROM Employees e
WHERE e.ManagerID IS NULL