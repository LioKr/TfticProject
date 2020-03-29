CREATE PROCEDURE [dbo].[SP_Character_ReadOne]
	@characterId int
AS
	SELECT * FROM [Character] WHERE CharacterId=@characterId
