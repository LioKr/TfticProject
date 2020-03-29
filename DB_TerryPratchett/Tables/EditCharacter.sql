CREATE TABLE [dbo].[EditCharacter]
(	
	[CharacterId] INT NOT NULL,
	[SgFormId] INT NOT NULL,
	[ValidatorAdmin] INT NOT NULL,

	CONSTRAINT FK_EditCharacter_QuoteId FOREIGN KEY ([CharacterId]) REFERENCES [Character]([CharacterId]),
	CONSTRAINT FK_EditCharacter_FormId FOREIGN KEY (SgFormId) REFERENCES SuggestionForm(SgFormId),
	CONSTRAINT FK_EditCharacter_UserId FOREIGN KEY (ValidatorAdmin) REFERENCES [User]([UserId])

)
