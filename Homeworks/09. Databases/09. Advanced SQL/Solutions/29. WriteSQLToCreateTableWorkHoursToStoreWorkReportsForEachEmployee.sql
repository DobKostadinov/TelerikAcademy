/*
29. Write a SQL to create table WorkHours to store work reports for each employee 
-(employee id, date, task, hours, comments).
-	Don't forget to define identity, primary key and appropriate foreign key.
-	Issue few SQL statements to insert, update and delete of some data in the table.
-	Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
-	For each change keep the old record data, the new record data and the command (insert / update / delete).
*/

CREATE TABLE WorkHours (
	EmployeeId INT IDENTITY,
	[Date] DATETIME,
	Task NVARCHAR(100),
	[Hours] INT,
	Comments NVARCHAR(300)
	CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId)
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeId)
	REFERENCES Employees(EmployeeId)
)
