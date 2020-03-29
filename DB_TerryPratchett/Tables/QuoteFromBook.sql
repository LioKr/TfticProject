CREATE TABLE [dbo].[QuoteFromBook]
(
	QuoteId INT NOT NULL,
	CharacterId INT NOT NULL,
	
	CONSTRAINT FK_QuoteFromBook_CharacterId Foreign KEY (CharacterId) REFERENCES [Character](CharacterId),
	CONSTRAINT FK_QuoteFromBook_QuoteId Foreign KEY (QuoteId) REFERENCES Quote(QuoteId)

)
