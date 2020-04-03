CREATE PROCEDURE [dbo].[SP_User_Add]	
	@firstname NVARCHAR(50),
	@lastname NVARCHAR(50),
	@email NVARCHAR(50),
	@userName NVARCHAR(50),
	@password NVARCHAR(50),
	@role NVARCHAR(2)
AS
	INSERT INTO [dbo].[User]([Firstname],[Lastname],[Email],[Username],[Password],[Role]) 
	OUTPUT Inserted.UserId
	VALUES (@firstname,@lastname,@email,@userName,dbo.SF_Hash_Password(@password),@role)
