
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2025 11:23:52
-- Generated from EDMX file: C:\Users\pallapu.sandhya\source\repos\ModelFirstdemo\ModelFirstdemo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [pizzadb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomersOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_CustomersOrders];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pizzas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pizzas];
GO
IF OBJECT_ID(N'[dbo].[Book]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Book];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pizzas'
CREATE TABLE [dbo].[Pizzas] (
    [pizzaid] int IDENTITY(1,1) NOT NULL,
    [pname] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [pizzatype] nvarchar(max)  NOT NULL,
    [price] nvarchar(max)  NOT NULL,
    [toppings] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Book'
CREATE TABLE [dbo].[Book] (
    [BookId] int  NOT NULL,
    [Bookname] varchar(20)  NOT NULL,
    [author] nvarchar(max)  NOT NULL,
    [price] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [custId] int IDENTITY(1,1) NOT NULL,
    [custname] nvarchar(max)  NOT NULL,
    [age] nvarchar(max)  NOT NULL,
    [custaddress] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [orderId] int IDENTITY(1,1) NOT NULL,
    [orddate] nvarchar(max)  NOT NULL,
    [product] nvarchar(max)  NOT NULL,
    [qty] nvarchar(max)  NOT NULL,
    [Customers_custId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [pizzaid] in table 'Pizzas'
ALTER TABLE [dbo].[Pizzas]
ADD CONSTRAINT [PK_Pizzas]
    PRIMARY KEY CLUSTERED ([pizzaid] ASC);
GO

-- Creating primary key on [BookId] in table 'Book'
ALTER TABLE [dbo].[Book]
ADD CONSTRAINT [PK_Book]
    PRIMARY KEY CLUSTERED ([BookId] ASC);
GO

-- Creating primary key on [custId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([custId] ASC);
GO

-- Creating primary key on [orderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([orderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customers_custId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_CustomersOrders]
    FOREIGN KEY ([Customers_custId])
    REFERENCES [dbo].[Customers]
        ([custId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomersOrders'
CREATE INDEX [IX_FK_CustomersOrders]
ON [dbo].[Orders]
    ([Customers_custId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------