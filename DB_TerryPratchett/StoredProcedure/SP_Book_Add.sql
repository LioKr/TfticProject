CREATE PROCEDURE [dbo].[SP_Book_Add]
	@BookId INT,
	@Title NVARCHAR(50),
	@ReleaseYear INT,
	@IsDiscWorld BIT,
	@SagaName NVARCHAR(50),
	@LastEdit DATETIME2
AS
	INSERT INTO [dbo].[Book] (BookId,Title,ReleaseYear,IsDiscWorld,SagaName,LastEdit)
	VALUES (@BookId, @Title,@ReleaseYear,@IsDiscWorld,@SagaName,@LastEdit)
