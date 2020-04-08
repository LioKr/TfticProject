CREATE PROCEDURE [dbo].[SP_Person_Delete]
	@PersonId INT
AS
	DELETE FROM [dbo].[Person] WHERE PersonId=@PersonId
