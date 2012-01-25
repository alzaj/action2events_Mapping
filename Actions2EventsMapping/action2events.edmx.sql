
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/10/2012 15:31:17
-- Generated from EDMX file: C:\Users\zajcev\winapps\Actions2EventsMapping\Actions2EventsMapping\action2events.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [action2events];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_task2event_events]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[task2event] DROP CONSTRAINT [FK_task2event_events];
GO
IF OBJECT_ID(N'[dbo].[FK_task2event_tasks]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[task2event] DROP CONSTRAINT [FK_task2event_tasks];
GO
IF OBJECT_ID(N'[dbo].[FK_tasks_tasks]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tasks] DROP CONSTRAINT [FK_tasks_tasks];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[events];
GO
IF OBJECT_ID(N'[dbo].[task2event]', 'U') IS NOT NULL
    DROP TABLE [dbo].[task2event];
GO
IF OBJECT_ID(N'[dbo].[tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tasks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'events'
CREATE TABLE [dbo].[events] (
    [event_id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(200)  NOT NULL,
    [attendedtask_id] int  NULL
);
GO

-- Creating table 'task2event'
CREATE TABLE [dbo].[task2event] (
    [id] int IDENTITY(1,1) NOT NULL,
    [task_id] int  NOT NULL,
    [event_id] int  NOT NULL
);
GO

-- Creating table 'tasks'
CREATE TABLE [dbo].[tasks] (
    [task_id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(200)  NOT NULL,
    [parenttask_id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [event_id] in table 'events'
ALTER TABLE [dbo].[events]
ADD CONSTRAINT [PK_events]
    PRIMARY KEY CLUSTERED ([event_id] ASC);
GO

-- Creating primary key on [id] in table 'task2event'
ALTER TABLE [dbo].[task2event]
ADD CONSTRAINT [PK_task2event]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [task_id] in table 'tasks'
ALTER TABLE [dbo].[tasks]
ADD CONSTRAINT [PK_tasks]
    PRIMARY KEY CLUSTERED ([task_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [event_id] in table 'task2event'
ALTER TABLE [dbo].[task2event]
ADD CONSTRAINT [FK_task2event_events]
    FOREIGN KEY ([event_id])
    REFERENCES [dbo].[events]
        ([event_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_task2event_events'
CREATE INDEX [IX_FK_task2event_events]
ON [dbo].[task2event]
    ([event_id]);
GO

-- Creating foreign key on [task_id] in table 'task2event'
ALTER TABLE [dbo].[task2event]
ADD CONSTRAINT [FK_task2event_tasks]
    FOREIGN KEY ([task_id])
    REFERENCES [dbo].[tasks]
        ([task_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_task2event_tasks'
CREATE INDEX [IX_FK_task2event_tasks]
ON [dbo].[task2event]
    ([task_id]);
GO

-- Creating foreign key on [parenttask_id] in table 'tasks'
ALTER TABLE [dbo].[tasks]
ADD CONSTRAINT [FK_tasks_tasks]
    FOREIGN KEY ([parenttask_id])
    REFERENCES [dbo].[tasks]
        ([task_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tasks_tasks'
CREATE INDEX [IX_FK_tasks_tasks]
ON [dbo].[tasks]
    ([parenttask_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------