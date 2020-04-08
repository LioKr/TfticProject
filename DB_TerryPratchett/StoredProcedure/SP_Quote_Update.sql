CREATE PROCEDURE [dbo].[SP_Quote_Update]
	@quoteId INT,
	@content NVARCHAR(max),
	@quote_Author INT,
	@quote_Book NVARCHAR(50),
	@lastEdit DATETIME2
	
AS
	UPDATE [dbo].[Quote]
	SET
	Content=@content,
	Quote_Author=@quote_Author,
	Quote_Book=@quote_Book,
	LastEdit=@lastEdit
	WHERE QuoteId=@quoteId

