USE [TelaDeCadastroELoginDb]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/07/2025 22:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[name] [varchar](30) NOT NULL,
	[password] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
