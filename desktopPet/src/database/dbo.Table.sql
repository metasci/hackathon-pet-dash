﻿CREATE TABLE [dbo].[EventLog]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DateTime] DATETIME NOT NULL, 
    [Event] VARCHAR(50) NOT NULL
)
