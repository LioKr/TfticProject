CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL IDENTITY,
	[Firstname] NVARCHAR(50) Not NULL,
	[Lastname] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(50) NOT NULL,
	[Username] NVARCHAR(50) NOT NULL,
	[Password] VarBinary(64) NOT NULL,
	[Role] NVARCHAR(2) NOT NULL,
	CONSTRAINT CHK_Role CHECK ([Role]='A' OR [Role]='C'),
	CONSTRAINT UK_Username UNIQUE (Username),
	CONSTRAINT PK_UserId PRIMARY KEY ([UserId])
)
