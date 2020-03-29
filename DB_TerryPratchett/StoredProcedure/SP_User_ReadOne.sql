CREATE PROCEDURE [dbo].[SP_User_ReadOne]
	@userId int
	
AS
	SELECT * FROM [User] WHERE UserId=@userId