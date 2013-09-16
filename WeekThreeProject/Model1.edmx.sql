
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/15/2013 02:22:58
-- Generated from EDMX file: C:\Users\ana\documents\visual studio 2012\Projects\WeekThreeProject\WeekThreeProject\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PicturePerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pictures] DROP CONSTRAINT [FK_PicturePerson];
GO
IF OBJECT_ID(N'[dbo].[FK_LabPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_LabPerson];
GO
IF OBJECT_ID(N'[dbo].[FK_GradesPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grades] DROP CONSTRAINT [FK_GradesPerson];
GO
IF OBJECT_ID(N'[dbo].[FK_ActivityGrades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grades] DROP CONSTRAINT [FK_ActivityGrades];
GO
IF OBJECT_ID(N'[dbo].[FK_ScheduleActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Activities] DROP CONSTRAINT [FK_ScheduleActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_ScheduleLab]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Labs] DROP CONSTRAINT [FK_ScheduleLab];
GO
IF OBJECT_ID(N'[dbo].[FK_ClassFileActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Activities] DROP CONSTRAINT [FK_ClassFileActivity];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Pictures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pictures];
GO
IF OBJECT_ID(N'[dbo].[Labs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Labs];
GO
IF OBJECT_ID(N'[dbo].[Grades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grades];
GO
IF OBJECT_ID(N'[dbo].[Activities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activities];
GO
IF OBJECT_ID(N'[dbo].[Schedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedules];
GO
IF OBJECT_ID(N'[dbo].[ClassFiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClassFiles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [Username] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [PictureID] int  NOT NULL,
    [LabId] int  NOT NULL,
    [ClassID] int  NULL
);
GO

-- Creating table 'Pictures'
CREATE TABLE [dbo].[Pictures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PictureFile] nvarchar(max)  NULL,
    [PersonId] int  NOT NULL
);
GO

-- Creating table 'Labs'
CREATE TABLE [dbo].[Labs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonID] nvarchar(max)  NOT NULL,
    [ClassID] nvarchar(max)  NOT NULL,
    [ScheduleId] int  NOT NULL
);
GO

-- Creating table 'Grades'
CREATE TABLE [dbo].[Grades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] int  NULL,
    [PersonId] int  NOT NULL,
    [ActivityId] int  NOT NULL
);
GO

-- Creating table 'Activities'
CREATE TABLE [dbo].[Activities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [ScheduleId] int  NOT NULL,
    [ClassFileId] int  NOT NULL
);
GO

-- Creating table 'Schedules'
CREATE TABLE [dbo].[Schedules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DayoftheWeek] nvarchar(max)  NULL,
    [Time] nvarchar(max)  NULL
);
GO

-- Creating table 'ClassFiles'
CREATE TABLE [dbo].[ClassFiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [File] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [PK_Pictures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Labs'
ALTER TABLE [dbo].[Labs]
ADD CONSTRAINT [PK_Labs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grades'
ALTER TABLE [dbo].[Grades]
ADD CONSTRAINT [PK_Grades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [PK_Activities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [PK_Schedules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClassFiles'
ALTER TABLE [dbo].[ClassFiles]
ADD CONSTRAINT [PK_ClassFiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonId] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [FK_PicturePerson]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PicturePerson'
CREATE INDEX [IX_FK_PicturePerson]
ON [dbo].[Pictures]
    ([PersonId]);
GO

-- Creating foreign key on [LabId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_LabPerson]
    FOREIGN KEY ([LabId])
    REFERENCES [dbo].[Labs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LabPerson'
CREATE INDEX [IX_FK_LabPerson]
ON [dbo].[People]
    ([LabId]);
GO

-- Creating foreign key on [PersonId] in table 'Grades'
ALTER TABLE [dbo].[Grades]
ADD CONSTRAINT [FK_GradesPerson]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GradesPerson'
CREATE INDEX [IX_FK_GradesPerson]
ON [dbo].[Grades]
    ([PersonId]);
GO

-- Creating foreign key on [ActivityId] in table 'Grades'
ALTER TABLE [dbo].[Grades]
ADD CONSTRAINT [FK_ActivityGrades]
    FOREIGN KEY ([ActivityId])
    REFERENCES [dbo].[Activities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ActivityGrades'
CREATE INDEX [IX_FK_ActivityGrades]
ON [dbo].[Grades]
    ([ActivityId]);
GO

-- Creating foreign key on [ScheduleId] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [FK_ScheduleActivity]
    FOREIGN KEY ([ScheduleId])
    REFERENCES [dbo].[Schedules]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScheduleActivity'
CREATE INDEX [IX_FK_ScheduleActivity]
ON [dbo].[Activities]
    ([ScheduleId]);
GO

-- Creating foreign key on [ScheduleId] in table 'Labs'
ALTER TABLE [dbo].[Labs]
ADD CONSTRAINT [FK_ScheduleLab]
    FOREIGN KEY ([ScheduleId])
    REFERENCES [dbo].[Schedules]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScheduleLab'
CREATE INDEX [IX_FK_ScheduleLab]
ON [dbo].[Labs]
    ([ScheduleId]);
GO

-- Creating foreign key on [ClassFileId] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [FK_ClassFileActivity]
    FOREIGN KEY ([ClassFileId])
    REFERENCES [dbo].[ClassFiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassFileActivity'
CREATE INDEX [IX_FK_ClassFileActivity]
ON [dbo].[Activities]
    ([ClassFileId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------