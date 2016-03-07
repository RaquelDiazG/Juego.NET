
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/07/2016 22:06:51
-- Generated from EDMX file: C:\Users\raque\Documents\Visual Studio 2015\Projects\PRACTICA1\JuegoCartas\JuegoCartas\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO

GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Palabras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Palabras];
GO
IF OBJECT_ID(N'[dbo].[Puntuaciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Puntuaciones];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Palabras'
CREATE TABLE [dbo].[Palabras] (
    [Id] int  NOT NULL,
    [Original] varchar(100)  NULL,
    [Sin_acentos] varchar(100)  NULL,
    [Sensible] varchar(100)  NULL
);
GO

-- Creating table 'Puntuaciones'
CREATE TABLE [dbo].[Puntuaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(100)  NULL,
    [Tiempo] int  NULL,
    [Movimientos] int  NULL,
    [Nivel] varchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Palabras'
ALTER TABLE [dbo].[Palabras]
ADD CONSTRAINT [PK_Palabras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Puntuaciones'
ALTER TABLE [dbo].[Puntuaciones]
ADD CONSTRAINT [PK_Puntuaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------