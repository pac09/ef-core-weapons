USE [Finance]
GO

INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Jorge', 'Levy', 'ID-4768744', 'Somewhere in Sacramento', '2022-01-05 04:52:55.897')
GO
INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Lautaro', 'Carro', 'ID-4769745', 'A place in Caballito', '2022-01-08 04:52:55.897')
GO
INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Byron', 'Canales', 'ID-4765842', 'Somewhere in Managua', '2022-01-06 04:52:55.897')
GO
INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Ronaldo', 'Cano', 'ID-4762647', 'Somewhere in Managua', '2022-01-05 04:52:55.897')
GO
INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Denis', 'Cano', 'ID-4766823', 'Somewhere in Masaya', '2022-01-06 04:52:55.897')
GO
INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Denis', 'Cano', 'ID-4766823', 'Somewhere in Masaya', '2022-01-06 04:52:55.897')
GO
INSERT INTO [dbo].[Person]([FirstName],[LastName],[Id],[Address],[CreationDate])
     VALUES ('Gaby', 'Centeno', 'ID-4767895', 'Somewhere in Santo Domingo', '2022-01-10 04:52:55.897')
GO




INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (6, 50, 'Invoice #1', '2022-02-01 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (6, 100, 'Invoice #2', '2022-02-06 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (6, 50, 'Invoice #3', '2022-02-07 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (6, 120, 'Invoice #4', '2022-02-08 04:52:55.897')
GO

INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (7, 30, 'Invoice #1', '2022-02-01 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (7, 40, 'Invoice #2', '2022-02-06 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (7, 20, 'Invoice #3', '2022-02-07 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (7, 10, 'Invoice #4', '2022-02-08 04:52:55.897')
GO

INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (4, 40, 'Invoice #1', '2022-02-01 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (4, 40, 'Invoice #2', '2022-02-06 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (4, 20, 'Invoice #3', '2022-02-07 04:52:55.897')
GO
INSERT INTO [dbo].[Credits]([PersonId],[Amount],[Description],[CreationDate])
     VALUES (4, 20, 'Invoice #4', '2022-02-08 04:52:55.897')
GO








INSERT INTO [dbo].[SocialSecurity]([PersonId],[CreationDate])
     VALUES (4, '2021-01-01 04:52:55.897')
GO

INSERT INTO [dbo].[SocialSecurity]([PersonId],[CreationDate])
     VALUES (6, '2021-02-01 04:52:55.897')
GO

INSERT INTO [dbo].[SocialSecurity]([PersonId],[CreationDate])
     VALUES (7, '2021-03-01 04:52:55.897')
GO

INSERT INTO [dbo].[SocialSecurity]([PersonId],[CreationDate])
     VALUES (3, '2021-01-01 04:52:55.897')
GO

INSERT INTO [dbo].[SocialSecurity]([PersonId],[CreationDate])
     VALUES (2, '2021-04-01 04:52:55.897')
GO









INSERT INTO [dbo].[Loans] ([PersonId],[Amount],[CreationDate], [EndDate])
     VALUES (2, 5000, '2022-01-15 04:52:55.897', NULL)
GO

INSERT INTO [dbo].[Loans] ([PersonId],[Amount],[CreationDate], [EndDate])
     VALUES (7, 1000, '2022-01-10 04:52:55.897', NULL)
GO






