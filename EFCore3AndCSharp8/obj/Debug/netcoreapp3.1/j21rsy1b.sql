IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Owners] (
    [OwnerId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Owners] PRIMARY KEY ([OwnerId])
);

GO

CREATE TABLE [Cats] (
    [CatId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [OwnerId] int NOT NULL,
    CONSTRAINT [PK_Cats] PRIMARY KEY ([CatId]),
    CONSTRAINT [FK_Cats_Owners_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [Owners] ([OwnerId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Cats_OwnerId] ON [Cats] ([OwnerId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200223150548_CatsDemoDb_First', N'3.1.2');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OwnerId', N'Name') AND [object_id] = OBJECT_ID(N'[Owners]'))
    SET IDENTITY_INSERT [Owners] ON;
INSERT INTO [Owners] ([OwnerId], [Name])
VALUES (1, N'Hasan');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OwnerId', N'Name') AND [object_id] = OBJECT_ID(N'[Owners]'))
    SET IDENTITY_INSERT [Owners] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OwnerId', N'Name') AND [object_id] = OBJECT_ID(N'[Owners]'))
    SET IDENTITY_INSERT [Owners] ON;
INSERT INTO [Owners] ([OwnerId], [Name])
VALUES (2, N'Faisan');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OwnerId', N'Name') AND [object_id] = OBJECT_ID(N'[Owners]'))
    SET IDENTITY_INSERT [Owners] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CatId', N'Name', N'OwnerId') AND [object_id] = OBJECT_ID(N'[Cats]'))
    SET IDENTITY_INSERT [Cats] ON;
INSERT INTO [Cats] ([CatId], [Name], [OwnerId])
VALUES (1, N'Hamlet', 1),
(2, N'King Lear', 1),
(3, N'Othello', 1),
(4, N'Hamlet1', 2),
(5, N'King Lear1', 2),
(6, N'Othello1', 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CatId', N'Name', N'OwnerId') AND [object_id] = OBJECT_ID(N'[Cats]'))
    SET IDENTITY_INSERT [Cats] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200223153521_CatsDemoDb_First_1', N'3.1.2');

GO

