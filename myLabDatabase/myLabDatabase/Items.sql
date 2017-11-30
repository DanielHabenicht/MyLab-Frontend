CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Inventarnummer] NCHAR(10) NULL, 
    [Bezeichnung] TEXT NOT NULL, 
    [Lagerort] TEXT NULL, 
    [Kommentar] TEXT NULL, 
    [Zustand] TEXT NOT NULL, 
    [Typ] INT NULL
)
