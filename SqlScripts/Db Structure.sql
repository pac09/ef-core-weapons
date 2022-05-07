USE [master]
GO

CREATE DATABASE [Finance];
GO 

USE [Finance]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person](
	[PersonId]		INT IDENTITY(1,1) NOT NULL,
	[FirstName]		VARCHAR (50) NOT NULL,
	[LastName]		VARCHAR (50) NOT NULL,
	[Id]			VARCHAR (10) NOT NULL,
	[Address]		VARCHAR (45) NOT NULL,
	[CreationDate]	DATETIME NOT NULL,
	PRIMARY KEY ([PersonId] ASC)
)
GO

CREATE TABLE [dbo].[Credits](
	[CreditId] INT IDENTITY(1,1) NOT NULL,
	[PersonId] INT NOT NULL,
	[Amount] BIGINT NOT NULL,
	[Description]	VARCHAR (50) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	PRIMARY KEY ([CreditId] ASC),
	CONSTRAINT FK_Credits_PersonId FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person]([PersonId])

)

GO

CREATE TABLE [dbo].[SocialSecurity](
	[SocialId] INT IDENTITY(1,1) NOT NULL,
	[PersonId] INT NOT NULL,
	[CreationDate] DATETIME NOT NULL,
	PRIMARY KEY ([SocialId] ASC),
	CONSTRAINT FK_SocialSecurity_PersonId FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person]([PersonId])
)

GO

CREATE TABLE [dbo].[Loans](
	[LoanId] INT IDENTITY(1,1) NOT NULL,
	[PersonId] INT NOT NULL,
	[Amount] BIGINT NOT NULL,
	[CreationDate] DATETIME NOT NULL,
	[EndDate] DATETIME NULL,
	PRIMARY KEY ([LoanId] ASC),
	CONSTRAINT FK_Loans_PersonId FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person]([PersonId])
)

GO


