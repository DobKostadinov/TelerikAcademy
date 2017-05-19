/*
14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
*/


SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff') AS [Current time and date]

--OR

SELECT CONVERT(VARCHAR(24), GETDATE(), 113) AS [Current Time]
