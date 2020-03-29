CREATE TABLE [dbo].[Person]
(
	[PersonId] INT NOT NULL IDENTITY,
	Firstname NVARCHAR(50) NOT NULL,
	Lastname NVARCHAR (50) NOT NULL,
	Birthdate DATE NOT NULL,
	Deathdate DATE,

	
	CONSTRAINT PK_PersonId PRIMARY KEY (PersonId)
)
