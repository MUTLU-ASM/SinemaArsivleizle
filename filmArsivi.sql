USE [FilmArsivi]
GO
/****** Object:  Table [dbo].[filmler]    Script Date: 14.08.2022 13:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filmler](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[kategori] [varchar](20) NULL,
	[link] [varchar](50) NULL,
	[durum] [bit] NULL,
 CONSTRAINT [PK_filmler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[filmler] ON 

INSERT [dbo].[filmler] ([ID], [ad], [kategori], [link], [durum]) VALUES (1, N'Lucy', N'Bilim Kurgu', N'https://www.youtube.com/watch?v=Wo5EKxXho6Y', 0)
INSERT [dbo].[filmler] ([ID], [ad], [kategori], [link], [durum]) VALUES (2, N'Zaman Sapması', N'Gerilim', N'https://www.youtube.com/watch?v=BYb-OPDMZ4o', 0)
INSERT [dbo].[filmler] ([ID], [ad], [kategori], [link], [durum]) VALUES (3, N'Gece Treni', N'Bilim Kurgu', N'https://www.youtube.com/watch?v=sQzLmVAD6oo', NULL)
INSERT [dbo].[filmler] ([ID], [ad], [kategori], [link], [durum]) VALUES (4, N'Ölümcül Takip', N'Aksiyon', N'https://www.youtube.com/watch?v=dg7AyhkTMZo', NULL)
SET IDENTITY_INSERT [dbo].[filmler] OFF
GO
