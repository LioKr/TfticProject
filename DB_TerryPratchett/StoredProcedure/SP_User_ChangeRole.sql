CREATE PROCEDURE [dbo].[SP_User_ChangeRole]
	@userId INT,	
	@role NVARCHAR(2)
AS
	UPDATE [dbo].[User]
	SET 
	[Role]=@role
	WHERE UserId=@userId

