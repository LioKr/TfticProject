CREATE PROCEDURE [dbo].[SP_Saga_Delete]
	@SagaId INT
AS
	DELETE FROM [Saga] WHERE SagaId=@SagaId
