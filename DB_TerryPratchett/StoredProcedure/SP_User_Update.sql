CREATE PROCEDURE [dbo].[SP_User_Update]
	@userId INT,
	@firstname NVARCHAR(50),
	@lastname NVARCHAR(50),
	@email NVARCHAR(50),
	@userName NVARCHAR(50),
	@password NVARCHAR(50),
	@role NVARCHAR(2)
AS
	UPDATE [dbo].[User]
	SET 
	[Firstname]=@firstname,
	[Lastname]=@lastname,
	[Email]=@email,
	[Username]=@userName,
	[Password]=dbo.SF_Hash_Password(@password)
	WHERE UserId=@userId

