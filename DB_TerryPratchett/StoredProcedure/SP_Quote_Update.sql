CREATE PROCEDURE [dbo].[SP_Quote_Update]
	@quoteId INT,
	@content NVARCHAR(max),
	@lastEdit DATETIME2
	
AS
	UPDATE [dbo].[Quote]
	SET
	Content=@content,
	LastEdit=@lastEdit
	WHERE QuoteId=@quoteId

