CREATE PROCEDURE [dbo].[SP_Person_ReadOne]
	@PersonId INT
AS
	SELECT * FROM [dbo].[Person] WHERE PersonId=@PersonId
