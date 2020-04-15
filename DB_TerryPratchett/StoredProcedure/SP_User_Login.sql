CREATE PROCEDURE [dbo].[SP_User_Login]
	@Username NVARCHAR(50),
	@Password NVARCHAR(50)
AS
	SELECT [UserId],[Firstname],[Lastname],[Email],[Username],[Password],[Role]
	FROM [dbo].[User]
	WHERE Username = @Username 
		AND [Password] = dbo.SF_Hash_Password(@Password)
