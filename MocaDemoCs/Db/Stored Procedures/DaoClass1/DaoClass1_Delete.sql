CREATE PROCEDURE [dbo].[DaoClass1_Delete]
	@Id INT
AS


DELETE FROM	[trnTable]
WHERE	[Id] = @Id



RETURN 0
