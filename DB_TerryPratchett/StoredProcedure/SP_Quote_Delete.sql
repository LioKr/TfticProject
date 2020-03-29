CREATE PROCEDURE [dbo].[SP_Quote_Delete]
	@quoteId int
AS
	DELETE FROM Quote WHERE QuoteId=@quoteId
