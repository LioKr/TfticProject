CREATE TABLE [dbo].[Character]
(
	[CharacterId] INT NOT NULL IDENTITY,
	Firstname NVARCHAR(50),
	Lastname NVARCHAR(50),
	Nickname NVARCHAR(50) NOT NULL,
	Race NVARCHAR(50),
	[Role] NVARCHAR(50),
	CharacterDescription NVARCHAR(max),
	LastEdit DATETIME2,

	CONSTRAINT PK_CharacterId PRIMARY KEY (CharacterId)
)
