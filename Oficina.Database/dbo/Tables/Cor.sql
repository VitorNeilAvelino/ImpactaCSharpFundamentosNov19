CREATE TABLE [dbo].[Cor] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Nome] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Cor] PRIMARY KEY CLUSTERED ([Id] ASC)
);

