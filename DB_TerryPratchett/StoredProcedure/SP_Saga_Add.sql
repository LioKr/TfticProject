CREATE PROCEDURE [dbo].[SP_Saga_Add]
	@SagaName NVARCHAR(50)
AS
	INSERT INTO [dbo].[Saga] (SagaName)
	OUTPUT Inserted.SagaId
	VALUES (@SagaName)
