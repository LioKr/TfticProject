CREATE PROCEDURE [dbo].[SP_Character_]	
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR(50),
	@Nickname NVARCHAR(50),
	@Race NVARCHAR(50),
	@Role NVARCHAR(50),
	@LastEdit DATETIME2
AS
	INSERT INTO [dbo].[Character] (Firstname,Lastname,Nickname,Race,[Role],LastEdit)
	VALUES (@Firstname, @Lastname, @Nickname, @Race, @Role,@LastEdit)
