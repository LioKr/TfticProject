CREATE PROCEDURE [dbo].[SP_Author_Update]
	@AuthorId INT,
	@Biography NVARCHAR(max),
	@Picture NVARCHAR(max),
	@PersonId INT
AS
	UPDATE [dbo].Author
	SET	
	Biography=@Biography,
	Picture=@Picture,
	PersonId=@PersonId
	WHERE AuthorId=@AuthorId

