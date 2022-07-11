
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2022 10:53:55
-- Generated from EDMX file: C:\Users\Flia. Ballester\Desktop\TP-POO-Modulos-de-Seguridad\Modelo\Context.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EJEMPLODB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuariosPerfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_UsuariosPerfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilesFormulario_Perfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilesFormulario] DROP CONSTRAINT [FK_PerfilesFormulario_Perfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilesFormulario_Formulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilesFormulario] DROP CONSTRAINT [FK_PerfilesFormulario_Formulario];
GO
IF OBJECT_ID(N'[dbo].[FK_FormularioPermiso_Formulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormularioPermiso] DROP CONSTRAINT [FK_FormularioPermiso_Formulario];
GO
IF OBJECT_ID(N'[dbo].[FK_FormularioPermiso_Permiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormularioPermiso] DROP CONSTRAINT [FK_FormularioPermiso_Permiso];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Perfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfiles];
GO
IF OBJECT_ID(N'[dbo].[Formulario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formulario];
GO
IF OBJECT_ID(N'[dbo].[Permiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permiso];
GO
IF OBJECT_ID(N'[dbo].[PerfilesFormulario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilesFormulario];
GO
IF OBJECT_ID(N'[dbo].[FormularioPermiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormularioPermiso];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [Perfiles_Id] int  NOT NULL
);
GO

-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Formulario'
CREATE TABLE [dbo].[Formulario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Permiso'
CREATE TABLE [dbo].[Permiso] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PerfilesFormulario'
CREATE TABLE [dbo].[PerfilesFormulario] (
    [Perfiles_Id] int  NOT NULL,
    [Formulario_Id] int  NOT NULL
);
GO

-- Creating table 'FormularioPermiso'
CREATE TABLE [dbo].[FormularioPermiso] (
    [Formulario_Id] int  NOT NULL,
    [Permiso_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Formulario'
ALTER TABLE [dbo].[Formulario]
ADD CONSTRAINT [PK_Formulario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [PK_Permiso]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Perfiles_Id], [Formulario_Id] in table 'PerfilesFormulario'
ALTER TABLE [dbo].[PerfilesFormulario]
ADD CONSTRAINT [PK_PerfilesFormulario]
    PRIMARY KEY CLUSTERED ([Perfiles_Id], [Formulario_Id] ASC);
GO

-- Creating primary key on [Formulario_Id], [Permiso_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [PK_FormularioPermiso]
    PRIMARY KEY CLUSTERED ([Formulario_Id], [Permiso_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Perfiles_Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_UsuariosPerfiles]
    FOREIGN KEY ([Perfiles_Id])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosPerfiles'
CREATE INDEX [IX_FK_UsuariosPerfiles]
ON [dbo].[Usuarios]
    ([Perfiles_Id]);
GO

-- Creating foreign key on [Perfiles_Id] in table 'PerfilesFormulario'
ALTER TABLE [dbo].[PerfilesFormulario]
ADD CONSTRAINT [FK_PerfilesFormulario_Perfiles]
    FOREIGN KEY ([Perfiles_Id])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formulario_Id] in table 'PerfilesFormulario'
ALTER TABLE [dbo].[PerfilesFormulario]
ADD CONSTRAINT [FK_PerfilesFormulario_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[Formulario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilesFormulario_Formulario'
CREATE INDEX [IX_FK_PerfilesFormulario_Formulario]
ON [dbo].[PerfilesFormulario]
    ([Formulario_Id]);
GO

-- Creating foreign key on [Formulario_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [FK_FormularioPermiso_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[Formulario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permiso_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [FK_FormularioPermiso_Permiso]
    FOREIGN KEY ([Permiso_Id])
    REFERENCES [dbo].[Permiso]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormularioPermiso_Permiso'
CREATE INDEX [IX_FK_FormularioPermiso_Permiso]
ON [dbo].[FormularioPermiso]
    ([Permiso_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------