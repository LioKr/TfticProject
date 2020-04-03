CREATE TABLE [dbo].[EditBook]
(
	[BookId] INT NOT NULL,
	[SgFormId] INT NOT NULL,
	[ValidatorAdmin] INT NOT NULL,
	[Created] DATETIME2 NOT NULL

	CONSTRAINT DF_EditBook_Created DEFAULT (SysDateTime()),
	CONSTRAINT FK_EditBook_QuoteId FOREIGN KEY (BookId) REFERENCES Book(BookId),
	CONSTRAINT FK_EditBook_FormId FOREIGN KEY (SgFormId) REFERENCES SuggestionForm(SgFormId),
	CONSTRAINT FK_EditBook_UserId FOREIGN KEY (ValidatorAdmin) REFERENCES [User]([UserId])

)
