IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220425012450_bookraon')
BEGIN
    CREATE TABLE [Author] (
        [AuthorID] int NOT NULL IDENTITY,
        [AuthorName] nvarchar(max) NOT NULL,
        [Age] int NOT NULL,
        [DOB] datetime2 NOT NULL,
        CONSTRAINT [PK_Author] PRIMARY KEY ([AuthorID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220425012450_bookraon')
BEGIN
    CREATE TABLE [Books] (
        [BookID] int NOT NULL IDENTITY,
        [BookName] nvarchar(max) NOT NULL,
        [Review] nvarchar(max) NOT NULL,
        [price] int NOT NULL,
        [AuthorID] int NOT NULL,
        CONSTRAINT [PK_Books] PRIMARY KEY ([BookID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220425012450_bookraon')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220425012450_bookraon', N'6.0.4');
END;
GO

COMMIT;
GO

