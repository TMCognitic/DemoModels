CREATE TABLE [dbo].[Personne]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NVARCHAR(75) NOT NULL, 
    [Prenom] NVARCHAR(75) NOT NULL, 
    [Email] NVARCHAR(384) NOT NULL, 
    [Adresse] NVARCHAR(200) NOT NULL, 
    [Cp] INT NOT NULL, 
    [Localite] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Personne] PRIMARY KEY ([Id]) 
)
