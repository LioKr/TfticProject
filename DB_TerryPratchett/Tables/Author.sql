CREATE TABLE [dbo].[Author]
(
	[AuthorId] INT NOT NULL IDENTITY,
	Biography NVARCHAR(max) Not NULL,
	Picture NVARCHAR(max),
	PersonId INT NOT NULL,
	CONSTRAINT PK_AuthorId PRIMARY KEY (AuthorId),
	CONSTRAINT FK_Author_PersonId Foreign KEY (PersonId) REFERENCES Person(PersonId)

)
