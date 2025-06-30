
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2025 14:49:43
-- Generated from EDMX file: C:\Users\pallapu.sandhya\source\repos\OnlineShop\OnlineShop\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Onlineshop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[products];
GO
IF OBJECT_ID(N'[dbo].[userorders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[userorders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [pid] varchar(10)  NOT NULL,
    [pname] varchar(20)  NULL,
    [description] varchar(50)  NULL,
    [price] int  NULL,
    [pimage] varchar(50)  NULL
);
GO

-- Creating table 'Registers'
CREATE TABLE [dbo].[Registers] (
    [uname] varchar(20)  NOT NULL,
    [password] varchar(20)  NULL,
    [gender] bit  NULL,
    [Age] int  NULL,
    [email] varchar(50)  NULL,
    [country] varchar(20)  NULL
);
GO

-- Creating table 'userorders'
CREATE TABLE [dbo].[userorders] (
    [tranid] int IDENTITY(1,1) NOT NULL,
    [username] varchar(20)  NULL,
    [pid] varchar(10)  NULL,
    [transdate] datetime  NULL,
    [qty] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [pid] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([pid] ASC);
GO

-- Creating primary key on [uname] in table 'Registers'
ALTER TABLE [dbo].[Registers]
ADD CONSTRAINT [PK_Registers]
    PRIMARY KEY CLUSTERED ([uname] ASC);
GO

-- Creating primary key on [tranid] in table 'userorders'
ALTER TABLE [dbo].[userorders]
ADD CONSTRAINT [PK_userorders]
    PRIMARY KEY CLUSTERED ([tranid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------