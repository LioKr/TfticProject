CREATE PROCEDURE [dbo].[SP_Check_User]
	@userName NVARCHAR(50),
	@password NVARCHAR(50),
	@isOK BIT OUTPUT
AS
	SET @isOK=0;
	IF EXISTS(
	SELECT UserId
	FROM [dbo].[User]
	WHERE Username = @userName
	AND [Password]=[dbo].SF_Hash_Password(@password))
	SET @isOK=1;
	
