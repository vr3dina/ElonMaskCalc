CREATE TABLE [dbo].[OperationResult] (
    [Id]           BIGINT          IDENTITY (1, 1) NOT NULL,
    [OperationId]  BIGINT          NOT NULL,
    [Result]       FLOAT            NULL,
    [Args]         NVARCHAR (1000) NULL,
    [CreationDate] DATETIME        NULL,
    [Status]       INT             NOT NULL,
    [UserId]       BIGINT          NOT NULL,
    [ExecTime]     BIGINT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OperationResult_Operation] FOREIGN KEY ([OperationId]) REFERENCES [dbo].[Operation] ([Id]),
    CONSTRAINT [FK_OperationResult_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

CREATE TABLE [dbo].[Operation] (
    [Id]        BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (1000) NOT NULL,
    [Rating ]   INT             NOT NULL,
    [ArgsCount] INT             NULL,
    [Owner]     NVARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Login]    NVARCHAR (50)   NOT NULL,
    [Password] NVARCHAR (MAX)  NOT NULL,
    [Roles]    NVARCHAR (50)   NULL,
    [Email]    NVARCHAR (50)   NULL,
    [BirthDay] DATETIME        NULL,
    [Status]   INT             NOT NULL,
    [Company]  NVARCHAR (1000) NULL,
    [Sex]      BIT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

