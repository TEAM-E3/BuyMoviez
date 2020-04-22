
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2020 10:42:11
-- Generated from EDMX file: C:\Users\s00178556\Desktop\OOD\BuyMoviez\BuyMoviez\BuyMoviez\Movies.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MoviesAndActors];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Release] int  NOT NULL,
    [Director] nvarchar(max)  NOT NULL,
    [Producer] nvarchar(max)  NOT NULL,
    [Genre] nvarchar(max)  NOT NULL,
    [Sales] int  NOT NULL
);
GO

-- Creating table 'Actors'
CREATE TABLE [dbo].[Actors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Actor1] nvarchar(max)  NOT NULL,
    [Actor2] nvarchar(max)  NOT NULL,
    [Actor3] nvarchar(max)  NOT NULL,
    [MovieId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Actors'
ALTER TABLE [dbo].[Actors]
ADD CONSTRAINT [PK_Actors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MovieId] in table 'Actors'
ALTER TABLE [dbo].[Actors]
ADD CONSTRAINT [FK_MovieActors]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieActors'
CREATE INDEX [IX_FK_MovieActors]
ON [dbo].[Actors]
    ([MovieId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------