﻿CREATE TABLE [dbo].[WaterLog]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [DateTime] DATETIME NOT NULL, 
    [Ounces] INT NOT NULL,
)
