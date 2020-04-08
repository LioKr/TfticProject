CREATE PROCEDURE [dbo].[SP_Author_Delete]
	@AuthorId int
AS
	DELETE FROM Author WHERE AuthorId=@AuthorId
