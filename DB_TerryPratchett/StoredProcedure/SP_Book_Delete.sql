CREATE PROCEDURE [dbo].[SP_Book_Delete]
@BookId int
AS
	DELETE FROM [Book] WHERE BookId=@BookId
