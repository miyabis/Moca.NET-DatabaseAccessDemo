CREATE TABLE [dbo].[trnTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Flg] BIT NULL, 
    [AmountOfMoney] MONEY NULL,
    [InsertDate] DATETIME NOT NULL, 
    [UpdateDate] DATETIME NULL, 
)
