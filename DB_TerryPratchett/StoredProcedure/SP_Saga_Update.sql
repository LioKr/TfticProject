CREATE PROCEDURE [dbo].[SP_Saga_Update]
	@SagaId int ,
	@SagaName NVARCHAR(50)
AS
	UPDATE dbo.Saga
	SET
	
	SagaName=@SagaName
	WHERE SagaId=@SagaId
