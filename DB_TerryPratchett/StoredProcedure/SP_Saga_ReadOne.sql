CREATE PROCEDURE [dbo].[SP_Saga_ReadOne]
	@SagaId INT
AS
	SELECT * FROM Saga WHERE SagaId=@SagaId
