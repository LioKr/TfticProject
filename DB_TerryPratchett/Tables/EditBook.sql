CREATE TABLE [dbo].[EditBook]
(
	[BookId] INT NOT NULL,
	[SgFormId] INT NOT NULL,
	[ValidatorAdmin] INT NOT NULL,

	CONSTRAINT FK_EditBook_QuoteId FOREIGN KEY (BookId) REFERENCES Book(BookId),
	CONSTRAINT FK_EditBook_FormId FOREIGN KEY (SgFormId) REFERENCES SuggestionForm(SgFormId),
	CONSTRAINT FK_EditBook_UserId FOREIGN KEY (ValidatorAdmin) REFERENCES [User]([UserId])

)
