CREATE PROCEDURE [dbo].[SP_Character_Delete]
	@characterId int
AS
	DELETE FROM [Character] WHERE CharacterId=@characterId
