CREATE PROCEDURE [dbo].[SP_Book_Update]
		@BookId INT,
	@Title NVARCHAR(50),
	@ReleaseYear INT,
	@IsDiscWorld BIT,
	@SagaName NVARCHAR(50),
	@LastEdit DATETIME2
AS
	UPDATE [dbo].[Book] 
	SET 
	Title=@Title,
	ReleaseYear=@ReleaseYear,
	IsDiscWorld=@IsDiscWorld,
	SagaName=@SagaName,
	LastEdit=@LastEdit
	WHERE BookId=@BookId
