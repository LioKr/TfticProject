CREATE PROCEDURE [dbo].[SP_Quote_ReadOne]
	@quoteId int
	
AS
	SELECT * FROM [Quote] WHERE QuoteId=@quoteId
