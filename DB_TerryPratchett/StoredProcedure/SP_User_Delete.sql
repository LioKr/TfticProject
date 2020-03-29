CREATE PROCEDURE [dbo].[SP_User_Delete]
	@userId int
AS
	DELETE FROM [User] WHERE UserId=@userId
