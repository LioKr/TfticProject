CREATE PROCEDURE [dbo].[SP_Quote_Add]
	@content NVARCHAR(max),
	@quote_Author INT,
	@quote_Book NVARCHAR(50),
	@lastEdit DATETIME2
	
AS
	INSERT INTO [dbo].[Quote](Content,Quote_Author,Quote_Book, LastEdit) 
	OUTPUT Inserted.QuoteId
	VALUES (@content,@quote_Author,@quote_Book, @lastEdit)

