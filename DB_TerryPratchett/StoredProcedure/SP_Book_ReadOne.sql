CREATE PROCEDURE [dbo].[SP_Book_ReadOne]
	@BookId int
AS
	SELECT * FROM [Book] WHERE BookId=@BookId
