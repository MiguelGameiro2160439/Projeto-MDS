
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2017 12:46:31
-- Generated from EDMX file: C:\Users\migue\Desktop\Projeto MDS\Projeto MDS\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HealthIT];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MédicoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_MédicoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_EspecialidadeMédico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Médico] DROP CONSTRAINT [FK_EspecialidadeMédico];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_PacienteConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_RececionistaConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_RececionistaConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_Médico_inherits_Utilizador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Médico] DROP CONSTRAINT [FK_Médico_inherits_Utilizador];
GO
IF OBJECT_ID(N'[dbo].[FK_Rececionista_inherits_Utilizador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UtilizadorSet_Rececionista] DROP CONSTRAINT [FK_Rececionista_inherits_Utilizador];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UtilizadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet];
GO
IF OBJECT_ID(N'[dbo].[ConsultaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaSet];
GO
IF OBJECT_ID(N'[dbo].[EspecialidadeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EspecialidadeSet];
GO
IF OBJECT_ID(N'[dbo].[PacienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PacienteSet];
GO
IF OBJECT_ID(N'[dbo].[UtilizadorSet_Médico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet_Médico];
GO
IF OBJECT_ID(N'[dbo].[UtilizadorSet_Rececionista]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtilizadorSet_Rececionista];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UtilizadorSet'
CREATE TABLE [dbo].[UtilizadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [N_Contribuinte] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [N_Telemovel] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL
);
GO

-- Creating table 'ConsultaSet'
CREATE TABLE [dbo].[ConsultaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [id_paciente] int  NOT NULL,
    [id_medico] int  NOT NULL,
    [id_rececionista] int  NOT NULL,
    [Médico_Id] int  NOT NULL,
    [Rececionista_Id] int  NOT NULL
);
GO

-- Creating table 'EspecialidadeSet'
CREATE TABLE [dbo].[EspecialidadeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PacienteSet'
CREATE TABLE [dbo].[PacienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [N_Contribuinte] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [NºTelemovel] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Médico'
CREATE TABLE [dbo].[UtilizadorSet_Médico] (
    [id_especialidade] int  NOT NULL,
    [HoraEntrada] nvarchar(max)  NOT NULL,
    [HoraSaida] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Rececionista'
CREATE TABLE [dbo].[UtilizadorSet_Rececionista] (
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UtilizadorSet'
ALTER TABLE [dbo].[UtilizadorSet]
ADD CONSTRAINT [PK_UtilizadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [PK_ConsultaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EspecialidadeSet'
ALTER TABLE [dbo].[EspecialidadeSet]
ADD CONSTRAINT [PK_EspecialidadeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PacienteSet'
ALTER TABLE [dbo].[PacienteSet]
ADD CONSTRAINT [PK_PacienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Médico'
ALTER TABLE [dbo].[UtilizadorSet_Médico]
ADD CONSTRAINT [PK_UtilizadorSet_Médico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Rececionista'
ALTER TABLE [dbo].[UtilizadorSet_Rececionista]
ADD CONSTRAINT [PK_UtilizadorSet_Rececionista]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Médico_Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_MédicoConsulta]
    FOREIGN KEY ([Médico_Id])
    REFERENCES [dbo].[UtilizadorSet_Médico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MédicoConsulta'
CREATE INDEX [IX_FK_MédicoConsulta]
ON [dbo].[ConsultaSet]
    ([Médico_Id]);
GO

-- Creating foreign key on [id_especialidade] in table 'UtilizadorSet_Médico'
ALTER TABLE [dbo].[UtilizadorSet_Médico]
ADD CONSTRAINT [FK_EspecialidadeMédico]
    FOREIGN KEY ([id_especialidade])
    REFERENCES [dbo].[EspecialidadeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EspecialidadeMédico'
CREATE INDEX [IX_FK_EspecialidadeMédico]
ON [dbo].[UtilizadorSet_Médico]
    ([id_especialidade]);
GO

-- Creating foreign key on [id_paciente] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([id_paciente])
    REFERENCES [dbo].[PacienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[ConsultaSet]
    ([id_paciente]);
GO

-- Creating foreign key on [Rececionista_Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_RececionistaConsulta]
    FOREIGN KEY ([Rececionista_Id])
    REFERENCES [dbo].[UtilizadorSet_Rececionista]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RececionistaConsulta'
CREATE INDEX [IX_FK_RececionistaConsulta]
ON [dbo].[ConsultaSet]
    ([Rececionista_Id]);
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Médico'
ALTER TABLE [dbo].[UtilizadorSet_Médico]
ADD CONSTRAINT [FK_Médico_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Rececionista'
ALTER TABLE [dbo].[UtilizadorSet_Rececionista]
ADD CONSTRAINT [FK_Rececionista_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------