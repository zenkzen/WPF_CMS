CREATE TABLE [dbo].[Appointments] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [Time]       DATETIME NOT NULL,
    [CustomerId] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Appointments_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
);

CREATE TABLE [dbo].[Customers] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [Name]     NCHAR (50) NOT NULL,
    [IdNumber] NCHAR (50) NOT NULL,
    [Address]  NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
