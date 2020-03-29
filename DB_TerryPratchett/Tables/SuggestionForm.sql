CREATE TABLE [dbo].[SuggestionForm]
(
	[SgFormId] INT NOT NULL IDENTITY,
	CharacterEditSuggestion NVARCHAR(max),
	QuoteEditSuggestion NVARCHAR(max),
	BookEditSuggestion NVARCHAR(max),
	UserId INT NOT NULL,
	SuggestionDate DATETIME2 NOT NULL,
	
	CONSTRAINT PK_FormId PRIMARY KEY (SgFormId),
	CONSTRAINT FK_SuggestionForm_UserId FOREIGN KEY (UserId) REFERENCES [User](UserId)
	
)
