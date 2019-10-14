CREATE PROCEDURE [dbo].[DaoClass1_Insert]
	@Id INT
    ,@Name NVARCHAR(50)
    ,@Flg BIT
    ,@AmountOfMoney MONEY
AS


INSERT INTO	[trnTable]
(
	[Id]
    ,[Name]
    ,[Flg]
    ,[AmountOfMoney]
    ,[InsertDate]
) VALUES (
	@Id
    ,@Name
    ,@Flg
    ,@AmountOfMoney
	,GETDATE()
)



RETURN 0
