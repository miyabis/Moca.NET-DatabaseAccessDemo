CREATE PROCEDURE [dbo].[DaoClass1_Find]
	@AmountOfMoney	money
AS


SELECT
	*
FROM	trnTable
WHERE	(@AmountOfMoney IS NULL OR (@AmountOfMoney IS NOT NULL AND AmountOfMoney >= @AmountOfMoney))



RETURN 0
