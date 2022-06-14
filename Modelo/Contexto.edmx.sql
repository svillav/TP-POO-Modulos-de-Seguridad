
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/13/2022 11:17:04
-- Generated from EDMX file: C:\Users\Martin\Documents\FACULTAD UAI\POO\TP FINAL\Vista\Modelo\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EJEMPLOBD];
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

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Grupo'
CREATE TABLE [dbo].[Grupo] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'UsuariosGrupo'
CREATE TABLE [dbo].[UsuariosGrupo] (
    [Usuarios_Id] int  NOT NULL,
    [Grupo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grupo'
ALTER TABLE [dbo].[Grupo]
ADD CONSTRAINT [PK_Grupo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Usuarios_Id], [Grupo_Id] in table 'UsuariosGrupo'
ALTER TABLE [dbo].[UsuariosGrupo]
ADD CONSTRAINT [PK_UsuariosGrupo]
    PRIMARY KEY CLUSTERED ([Usuarios_Id], [Grupo_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuarios_Id] in table 'UsuariosGrupo'
ALTER TABLE [dbo].[UsuariosGrupo]
ADD CONSTRAINT [FK_UsuariosGrupo_Usuarios]
    FOREIGN KEY ([Usuarios_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Grupo_Id] in table 'UsuariosGrupo'
ALTER TABLE [dbo].[UsuariosGrupo]
ADD CONSTRAINT [FK_UsuariosGrupo_Grupo]
    FOREIGN KEY ([Grupo_Id])
    REFERENCES [dbo].[Grupo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosGrupo_Grupo'
CREATE INDEX [IX_FK_UsuariosGrupo_Grupo]
ON [dbo].[UsuariosGrupo]
    ([Grupo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------