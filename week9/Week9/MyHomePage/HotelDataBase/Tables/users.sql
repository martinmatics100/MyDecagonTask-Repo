CREATE TABLE users
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(200) NOT NULL,
	LastName varchar(200) NOT NULL,
	Email varchar(200) NOT NULL,
	Pwd varchar(200) NOT NULL,
	DateCreation SMALLDATETIME NOT NULL DEFAULT GETDATE()

)
