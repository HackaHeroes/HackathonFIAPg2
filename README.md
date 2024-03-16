# HackathonFIAPg2

# Script Database
/****** Object:  Table [dbo].[VideoImages]    Script Date: 16/03/2024 14:43:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VideoImages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VideoName] [varchar](500) NULL,
	[VideoLink] [varchar](max) NULL,
	[CreatedAt] [smalldatetime] NULL,
	[ZipFile] [varchar](max) NULL,
	[ZipName] [varchar](500) NULL,
	[ZipCreatedAt] [smalldatetime] NULL,
	[IsProcessed] [bit] NULL,
 CONSTRAINT [PK_VideoImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[VideoImages] ADD  CONSTRAINT [DF_VideoImages_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO

ALTER TABLE [dbo].[VideoImages] ADD  CONSTRAINT [DF_VideoImages_FlgProcessed]  DEFAULT ((0)) FOR [IsProcessed]
GO

