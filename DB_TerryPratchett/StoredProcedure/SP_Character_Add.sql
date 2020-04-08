CREATE PROCEDURE [dbo].[SP_Character_Add]	
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR(50),
	@Nickname NVARCHAR(50),
	@Race NVARCHAR(50),
	@Role NVARCHAR(50),
	@CharacterDescription NVARCHAR(max),
	@LastEdit DATETIME2
AS
	INSERT INTO [dbo].[Character] (Firstname,Lastname,Nickname,Race,[Role],CharacterDescription,LastEdit)
	VALUES (@Firstname, @Lastname, @Nickname, @Race, @Role,@CharacterDescription,@LastEdit)
