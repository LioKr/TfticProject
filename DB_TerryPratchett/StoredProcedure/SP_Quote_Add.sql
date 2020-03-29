CREATE PROCEDURE [dbo].[SP_Quote_Add]
	@content NVARCHAR(max),
	@lastEdit DATETIME2
	
AS
	INSERT INTO [dbo].[Quote](Content, LastEdit) 
	VALUES (@content, @lastEdit)

