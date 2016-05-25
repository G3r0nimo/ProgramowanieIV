CREATE TABLE [dbo].event
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(50) NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [When] DATETIME NULL
)
