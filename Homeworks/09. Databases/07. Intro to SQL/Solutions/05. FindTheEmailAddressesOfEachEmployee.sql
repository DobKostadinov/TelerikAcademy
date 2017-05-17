/*Write a SQL query to find the email addresses of each employee (by his first and last name). 
  Consider that the mail domain is telerik.com.
  Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".*/

USE TelerikAcademy

SELECT e.FirstName + '.' + e.LastName + '@telerik.com' AS [Full Email Address]
FROM dbo.Employees e