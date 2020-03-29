CREATE TABLE [dbo].[EditQuote]
(
	[QuoteId] INT NOT NULL,
	[SgFormId] INT NOT NULL,
	[ValidatorAdmin] INT NOT NULL,

	CONSTRAINT FK_EditQuote_QuoteId FOREIGN KEY (QuoteId) REFERENCES Quote(QuoteId),
	CONSTRAINT FK_EditQuote_FormId FOREIGN KEY (SgFormId) REFERENCES SuggestionForm(SgFormId),
	CONSTRAINT FK_EditQuote_UserId FOREIGN KEY (ValidatorAdmin) REFERENCES [User]([UserId])

	
)
