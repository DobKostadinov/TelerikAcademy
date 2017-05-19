/*
16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
Test if the view works correctly. 
*/

CREATE VIEW [Recently Logged] AS
SELECT u.Username, u.LastLogTime
FROM Users u
WHERE
CONVERT(VARCHAR(10), LastLogTime, 102) <= CONVERT(VARCHAR(10) ,GETDATE(), 102)