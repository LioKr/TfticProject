CREATE PROCEDURE [dbo].[SP_Person_Add]
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR(50),
	@Birthdate DATE,
	@Deathdate DATE
AS
	INSERT INTO [dbo].[Person] (Firstname,Lastname,Birthdate,Deathdate)
	OUTPUT Inserted.PersonId
	VALUES (@Firstname, @Lastname, @Birthdate, @Deathdate)
