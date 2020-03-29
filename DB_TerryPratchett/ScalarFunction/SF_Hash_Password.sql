CREATE FUNCTION [dbo].[SF_Hash_Password]
(
	@password NVARCHAR(64)
)
RETURNS VARBINARY(64)
AS
BEGIN
	Declare @passwordWithNoise NVARCHAR(MAX)
	SET @passwordWithNoise= '@DDm04R'+@password+'N01z*'
	RETURN HASHBYTES(N'SHA2_564', @passwordWithNoise)
END
