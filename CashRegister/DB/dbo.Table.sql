﻿CREATE TABLE [dbo].[Items]
(
	[Id] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Price] SMALLMONEY NULL, 
    [Tags] NVARCHAR(MAX) NULL
)
