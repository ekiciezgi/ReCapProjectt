CREATE TABLE [dbo].[cars]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [Description ] NCHAR(10) NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] DECIMAL NULL, 
    [CarName] NCHAR(10) NULL
)
