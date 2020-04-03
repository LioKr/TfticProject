CREATE TABLE [dbo].[EditQuote]
(
	[QuoteId] INT NOT NULL,
	[SgFormId] INT NOT NULL,
	[ValidatorAdmin] INT NOT NULL,
	[Created] DATETIME2 NOT NULL

	CONSTRAINT DF_EditQuote_Created DEFAULT (SysDateTime()),
	CONSTRAINT FK_EditQuote_QuoteId FOREIGN KEY (QuoteId) REFERENCES Quote(QuoteId),
	CONSTRAINT FK_EditQuote_FormId FOREIGN KEY (SgFormId) REFERENCES SuggestionForm(SgFormId),
	CONSTRAINT FK_EditQuote_UserId FOREIGN KEY (ValidatorAdmin) REFERENCES [User]([UserId])

	
)
