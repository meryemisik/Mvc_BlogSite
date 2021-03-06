USE [BlogSiteDB]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime] NULL,
	[UyeID] [int] NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ArticlesPictures]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticlesPictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PictureSmall] [nvarchar](max) NULL,
	[PictureMedium] [nvarchar](max) NULL,
	[PictureLarge] [nvarchar](max) NULL,
	[ArticleID] [int] NULL,
 CONSTRAINT [PK_ArticlesPictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etiket]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiket](
	[EtiketID] [int] IDENTITY(1,1) NOT NULL,
	[EtiketAdi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Etiket] PRIMARY KEY CLUSTERED 
(
	[EtiketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hakkinda]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hakkinda](
	[HakkindaID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_hakkinda] PRIMARY KEY CLUSTERED 
(
	[HakkindaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Project]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
	[Beceriler] [nvarchar](max) NULL,
	[Sure] [nvarchar](50) NULL,
	[Fiyat] [int] NULL,
	[Url] [nvarchar](50) NULL,
	[Resim] [image] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectPictures]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectPictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PictureSmall] [image] NULL,
	[PictureMedium] [image] NULL,
	[PictureLarge] [image] NULL,
	[ProjectId] [nchar](10) NULL,
 CONSTRAINT [PK_ProjectPictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Service]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UyeAdi] [nvarchar](50) NOT NULL,
	[UyeSifre] [nvarchar](50) NOT NULL,
	[Yazarmi] [bit] NOT NULL,
	[UyelikTarih] [date] NULL,
	[Aktifmi] [bit] NOT NULL,
	[YetkiId] [int] NOT NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yetenek]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetenek](
	[YetenekId] [int] NOT NULL,
	[YetenekAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Yetenek] PRIMARY KEY CLUSTERED 
(
	[YetenekId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yetkiler]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_YEtkiler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yorum]    Script Date: 7.07.2021 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yorum](
	[YorumID] [int] IDENTITY(1,1) NOT NULL,
	[Yorum] [nvarchar](max) NULL,
	[MakaleID] [int] NULL,
	[EklenmeTarihi] [datetime] NULL,
	[AdSoyad] [nvarchar](50) NULL,
	[Begeni] [int] NULL,
 CONSTRAINT [PK_Yorum] PRIMARY KEY CLUSTERED 
(
	[YorumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([Id], [Title], [Content], [CreateDate], [UyeID], [CategoryID]) VALUES (13, N'Where can I get some?', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don''t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn''t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.', CAST(N'2021-06-03 13:26:00.187' AS DateTime), 3, 2)
INSERT [dbo].[Articles] ([Id], [Title], [Content], [CreateDate], [UyeID], [CategoryID]) VALUES (14, N'Why do we use it?', N'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using ''Content here, content here'', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for ''lorem ipsum'' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).', CAST(N'2021-06-03 13:28:16.797' AS DateTime), 2, 3)
INSERT [dbo].[Articles] ([Id], [Title], [Content], [CreateDate], [UyeID], [CategoryID]) VALUES (15, N'What is Lorem Ipsum?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum', CAST(N'2021-06-03 13:31:15.640' AS DateTime), 1, 3)
INSERT [dbo].[Articles] ([Id], [Title], [Content], [CreateDate], [UyeID], [CategoryID]) VALUES (16, N'1914 translation by H. Rackham', N'"But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?"', CAST(N'2021-06-03 13:33:54.070' AS DateTime), 2, 1)
INSERT [dbo].[Articles] ([Id], [Title], [Content], [CreateDate], [UyeID], [CategoryID]) VALUES (17, N'Section 1.10.33 of "de Finibus Bonorum et Malorum", written by Cicero in 45 BC', N'"At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat."', CAST(N'2021-06-03 13:40:35.160' AS DateTime), 3, 1)
SET IDENTITY_INSERT [dbo].[Articles] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, N'Bilgisayar')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, N'Tablet')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, N'Telefon')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (4, N'Televizyon')
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (5, N'Kamera')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[hakkinda] ON 

INSERT [dbo].[hakkinda] ([HakkindaID], [Adi], [Soyadi], [Aciklama]) VALUES (1, N'Meryem', N'Işık', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of "de Finibus Bonorum et Malorum" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, "Lorem ipsum dolor sit amet..", comes from a line in section 1.10.32.

The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.')
SET IDENTITY_INSERT [dbo].[hakkinda] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([Id], [Title], [Content], [Beceriler], [Sure], [Fiyat], [Url], [Resim]) VALUES (1, N'Vestibulum Tellus', N'Aenean lacinia bibendum nulla sed consectetur', N'HTML-CSS-JQUERY', N'15 Gün', 2000, N'https://www.google.com/', NULL)
SET IDENTITY_INSERT [dbo].[Project] OFF
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (1, N'Website Design')
INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (2, N'Website Development')
INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (3, N'Wordpress Theme Development')
INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (4, N'Mobile Apps UI/UX Design')
INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (5, N'Online Software Development')
INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (6, N'E-commerce Development')
INSERT [dbo].[Service] ([ServiceId], [ServiceAdi]) VALUES (7, N'UI/UX Consulting')
SET IDENTITY_INSERT [dbo].[Service] OFF
SET IDENTITY_INSERT [dbo].[Uyeler] ON 

INSERT [dbo].[Uyeler] ([Id], [UyeAdi], [UyeSifre], [Yazarmi], [UyelikTarih], [Aktifmi], [YetkiId]) VALUES (1, N'Salih', N'123', 1, CAST(N'2021-01-01' AS Date), 1, 1)
INSERT [dbo].[Uyeler] ([Id], [UyeAdi], [UyeSifre], [Yazarmi], [UyelikTarih], [Aktifmi], [YetkiId]) VALUES (3, N'meryem', N'123456', 1, CAST(N'2021-06-07' AS Date), 1, 2)
INSERT [dbo].[Uyeler] ([Id], [UyeAdi], [UyeSifre], [Yazarmi], [UyelikTarih], [Aktifmi], [YetkiId]) VALUES (4, N'Ali Gül', N'1234', 1, CAST(N'2021-06-07' AS Date), 1, 1)
SET IDENTITY_INSERT [dbo].[Uyeler] OFF
SET IDENTITY_INSERT [dbo].[Yetkiler] ON 

INSERT [dbo].[Yetkiler] ([Id], [YetkiAdi]) VALUES (1, N'Admin')
INSERT [dbo].[Yetkiler] ([Id], [YetkiAdi]) VALUES (2, N'Kullanıcı')
INSERT [dbo].[Yetkiler] ([Id], [YetkiAdi]) VALUES (3, N'Makale Yayıncı')
SET IDENTITY_INSERT [dbo].[Yetkiler] OFF
