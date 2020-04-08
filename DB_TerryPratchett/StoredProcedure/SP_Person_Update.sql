CREATE PROCEDURE [dbo].[SP_Person_Update]
	@PersonId INT,
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR(50),
	@Birthdate DATE,
	@Deathdate DATE
AS
	UPDATE [dbo].[Person]
	SET 
	Firstname=@Firstname,
	Lastname=@Lastname,
	Birthdate=@Birthdate,
	Deathdate=@Deathdate
	WHERE PersonId=@PersonId
