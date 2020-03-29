CREATE TABLE [dbo].[Book]
(
	[BookId] INT NOT NULL,	
	Title NVARCHAR(50) Not Null,
	ReleaseYear INT NOT NULL,
	IsDiscWorld BIT DEFAULT 1,
	SagaName NVARCHAR(50),
	LastEdit DATETIME2,
	
	CONSTRAINT FK_Book_SagaName FOREIGN KEY (SagaName) REFERENCES Saga(SagaName),
	CONSTRAINT UK_Title UNIQUE (Title),
	CONSTRAINT PK_BookId PRIMARY KEY (BookId)
)
