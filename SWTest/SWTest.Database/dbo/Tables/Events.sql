CREATE TABLE [dbo].[Events] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Title]            NVARCHAR (50)  NOT NULL,
    [Tecnology]        NVARCHAR (50)  NOT NULL,
    [StartingDate]     DATETIME       NOT NULL,
    [RegistrationLink] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([Id] ASC)
);

