CREATE PROCEDURE [dbo].[SP_Author_Add]
	@Biography NVARCHAR(max),
	@Picture NVARCHAR(max),
	@PersonId INT
AS
	INSERT INTO [dbo].[Author] (Biography,Picture,PersonId)
	OUTPUT Inserted.AuthorId
	VALUES (@Biography, @Picture,@PersonId)
