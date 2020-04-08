CREATE PROCEDURE [dbo].[SP_Author_ReadOne]
	@AuthorId int
	
AS
	SELECT * FROM [Author] WHERE AuthorId=@AuthorId
