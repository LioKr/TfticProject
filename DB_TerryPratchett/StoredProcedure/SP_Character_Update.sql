CREATE PROCEDURE [dbo].[SP_Character_Update]
	@CharacterId INT,
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR(50),
	@Nickname NVARCHAR(50),
	@Race NVARCHAR(50),
	@Role NVARCHAR(50),
	@CharacterDescription NVARCHAR(max),
	@LastEdit DATETIME2
AS
	UPDATE [dbo].[Character]
	SET 
	Firstname=@Firstname,
	Lastname=@Lastname,
	Nickname=@Nickname,
	Race=@Race,
	[Role]=@Role,
	CharacterDescription=@CharacterDescription,
	LastEdit=@LastEdit
	WHERE CharacterId=@CharacterId
