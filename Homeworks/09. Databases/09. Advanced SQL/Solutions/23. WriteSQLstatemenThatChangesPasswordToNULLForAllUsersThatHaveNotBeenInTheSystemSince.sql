/*
23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
*/

 UPDATE Users
 SET [Password] = NULL
 WHERE LastLogTime < CONVERT(datetime, '2010-03-10')