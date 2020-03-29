CREATE TABLE [dbo].[Quote]
(
	[QuoteId] INT NOT NULL IDENTITY,
	Content NVARCHAR(max) NOT NULL,
	Quote_Author INT,
	Quote_Book NVARCHAR(50) NOT NULL,
	LastEdit DATETIME2,
	CONSTRAINT PK_QuoteId PRIMARY KEY (QuoteId),
	CONSTRAINT FK_Quote_AuthorId FOREIGN KEY (Quote_Author) REFERENCES [Character](CharacterId),
	CONSTRAINT FK_Quote_BookName FOREIGN KEY (Quote_Book) REFERENCES [Book](Title)

)
