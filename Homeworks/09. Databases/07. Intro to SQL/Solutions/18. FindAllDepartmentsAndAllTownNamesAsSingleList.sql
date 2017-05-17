--Write a SQL query to find all departments and all town names as a single list. Use UNION.

USE TelerikAcademy

SELECT d.Name FROM dbo.Departments d
UNION
SELECT t.Name FROM dbo.Towns t
