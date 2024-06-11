USE [VehicleSalesDB]
GO

/****** Object:  Table [dbo].[User]    Script Date: 6/11/2024 8:05:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[Username] [varchar](60) NOT NULL,
	[Password] [varchar](60) NOT NULL,
	[FirstName] [varchar](30) NULL,
	[LastName] [varchar](30) NULL,
	[Address] [varchar](30) NULL,
	[City] [varchar](30) NULL,
	[PhoneNumber] [varchar](30) NULL,
	[CreatedOn] [date] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[User] ADD  DEFAULT (newid()) FOR [Id]
GO

