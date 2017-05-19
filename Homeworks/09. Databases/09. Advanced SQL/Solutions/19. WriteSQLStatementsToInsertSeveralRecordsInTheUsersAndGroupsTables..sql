/*
19. Write SQL statements to insert several records in the Users tables.
*/

INSERT INTO Groups([Name])
VALUES ('Front-end'),
	   ('Soft developer')


INSERT INTO Users(Username, [Password], FullName, LastLogTime)
VALUES('DiJ', '12345', 'Dim Jerkov', GETDATE()),
	  ('Tom', '12221', 'Tom Tomislav', GETDATE()),
	  ('Nitro', '534f3', 'Nikola Niolov', GETDATE())