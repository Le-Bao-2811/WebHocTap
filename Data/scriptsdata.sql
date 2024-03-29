USE [DoAnThucTap]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsSucces] [bit] NOT NULL,
	[IdQues] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryNew]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryNew](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCategoryNew] [nvarchar](max) NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_CategoryNew] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategorySub]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategorySub](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCategorySub] [nvarchar](max) NOT NULL,
	[Price] [int] NULL,
	[pathImg] [nvarchar](max) NOT NULL,
	[CountView] [int] NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
	[Descripstion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CategorySub] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chapter]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chapter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameChapter] [nvarchar](max) NOT NULL,
	[IdSubject] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Chapter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coment]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[IdUser] [int] NULL,
	[IdLesson] [int] NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Coment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lesson]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lesson](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Video] [nvarchar](max) NULL,
	[IdChapter] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Lesson] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MstPerMission]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MstPerMission](
	[Id] [int] NOT NULL,
	[Code] [varchar](500) NOT NULL,
	[Table] [varchar](500) NOT NULL,
	[Desc] [nvarchar](500) NOT NULL,
	[GroupName] [nvarchar](500) NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_MstPerMission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[pathImg] [nvarchar](max) NOT NULL,
	[IdCategoryNew] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchasedCourse]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchasedCourse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSub] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_PurchasedCourse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[IdUser] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolePermission]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[MStPermissionId] [int] NOT NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_RolePermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameSubject] [nvarchar](max) NOT NULL,
	[IdCategorySub] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NOT NULL,
	[IdChapter] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/5/2023 10:56:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[PasswordHash] [varbinary](max) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[Gmail] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[IdRole] [int] NULL,
	[CreateAt] [datetime2](7) NULL,
	[UpdateAt] [datetime2](7) NULL,
	[CreateBy] [int] NULL,
	[DeleteAt] [datetime2](7) NULL,
	[DetleteBy] [datetime2](7) NULL,
	[DislayOrder] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230527063328_taobang', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230529064327_themcot', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230530070105_suacot', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230531075837_themkhachhang', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230531115052_suabangkiemtra', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230531155605_suapk', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230604061424_pksualai', N'7.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230621111951_themcotprice', N'7.0.5')
GO
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'Cha', 0, 1, NULL, NULL, NULL, CAST(N'2023-05-31T22:42:54.7275659' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'Ông', 0, 1, NULL, NULL, NULL, CAST(N'2023-05-31T22:42:54.7251980' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, N'Bà', 0, 1, NULL, NULL, NULL, CAST(N'2023-05-31T22:42:54.7166854' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4, N'Mẹ', 1, 1, NULL, NULL, NULL, CAST(N'2023-05-31T22:42:54.5081819' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5, N'Su Su', 0, 2, NULL, NULL, NULL, CAST(N'2023-05-31T22:43:02.9079117' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6, N'Na Na', 0, 2, NULL, NULL, NULL, CAST(N'2023-05-31T22:43:02.9057783' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7, N'LA LA', 0, 2, NULL, NULL, NULL, CAST(N'2023-05-31T22:43:02.9033179' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8, N'Đô đô', 1, 2, NULL, NULL, NULL, CAST(N'2023-05-31T22:43:02.8991588' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9, N'4kg', 0, 3, NULL, NULL, NULL, CAST(N'2023-05-31T18:24:51.5834759' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (10, N'5kg', 0, 3, NULL, NULL, NULL, CAST(N'2023-05-31T18:24:51.5807076' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (11, N'2kg', 0, 3, NULL, NULL, NULL, CAST(N'2023-05-31T18:24:51.5718492' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (12, N'3kg', 1, 3, NULL, NULL, NULL, CAST(N'2023-05-31T18:24:51.3696881' AS DateTime2), NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (13, N'Cha', 0, 5, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (14, N'Ông', 0, 5, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (15, N'Bà', 0, 5, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (16, N'Mẹ', 1, 5, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (17, N'Su Su', 0, 6, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (18, N'Na Na', 0, 6, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (19, N'La La', 0, 6, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (20, N'Đô đô', 1, 6, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (21, N' một lớp kem', 0, 7, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (22, N'Một lớp tinh dầu', 0, 7, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (23, N'một lớp xà bông', 0, 7, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Answer] ([Id], [Description], [IsSucces], [IdQues], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (24, N'một lớp phấn', 1, 7, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Answer] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryNew] ON 

INSERT [dbo].[CategoryNew] ([Id], [NameCategoryNew], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'tin giựt gân', CAST(N'2023-06-11T10:35:46.9862294' AS DateTime2), CAST(N'2023-06-11T10:35:46.9862294' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[CategoryNew] ([Id], [NameCategoryNew], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'tin hot', CAST(N'2023-06-11T10:35:51.1550016' AS DateTime2), CAST(N'2023-06-11T10:35:51.1550016' AS DateTime2), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[CategoryNew] OFF
GO
SET IDENTITY_INSERT [dbo].[CategorySub] ON 

INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (1, N'Lớp 2', NULL, N'z3835472836387_0249d7e1f14768e2029-05-2023-14-56-36-488.jpg', 84, CAST(N'2023-05-29T14:56:36.5186704' AS DateTime2), CAST(N'2023-07-05T15:48:31.3403284' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả')
INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (2, N'Lớp 1', 2000000, N'logo29-05-2023-15-23-43-500.jpg', 10, CAST(N'2023-05-29T15:23:43.5225922' AS DateTime2), CAST(N'2023-06-10T15:06:33.3768629' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả môn học')
INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (8, N'Lớp 2 Nâng cao', 200000, N'CDL10_104-06-2023-12-58-06-335.jpg', 0, CAST(N'2023-06-04T12:58:08.6186247' AS DateTime2), CAST(N'2023-06-04T12:58:08.6186247' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả bài học')
INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (9, N'Lớp 2 Siêu nâng cao', 500000, N'quan-baggy-nam-80004-06-2023-12-58-38-936.jpg', 13, CAST(N'2023-06-04T12:58:39.6296650' AS DateTime2), CAST(N'2023-06-19T09:11:08.6480772' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả')
INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (10, N'Lớp 3 Nâng cao', 600000, N'somi04-06-2023-13-07-45-430.jpg', 2, CAST(N'2023-06-04T13:07:45.4596130' AS DateTime2), CAST(N'2023-06-10T15:06:23.1087581' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả')
INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (11, N'Lớp 6', NULL, N'quanthethao05-07-2023-13-18-21-832.jpg', 1, CAST(N'2023-07-05T13:18:21.8672523' AS DateTime2), CAST(N'2023-07-05T13:19:05.0481802' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả')
INSERT [dbo].[CategorySub] ([Id], [NameCategorySub], [Price], [pathImg], [CountView], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Descripstion]) VALUES (12, N'Lớp 7', NULL, N'ao-khoachoodie-tron-305-07-2023-13-23-19-453.jpg', 1, CAST(N'2023-07-05T13:23:19.4654928' AS DateTime2), CAST(N'2023-07-05T13:38:21.6861033' AS DateTime2), 1, NULL, NULL, NULL, N'Mô tả ')
SET IDENTITY_INSERT [dbo].[CategorySub] OFF
GO
SET IDENTITY_INSERT [dbo].[Chapter] ON 

INSERT [dbo].[Chapter] ([Id], [NameChapter], [IdSubject], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'Chương 3', 1, CAST(N'2023-05-31T17:43:38.8830599' AS DateTime2), CAST(N'2023-05-31T17:43:38.8830599' AS DateTime2), 1, CAST(N'2023-05-31T17:43:51.9099261' AS DateTime2), NULL, NULL)
INSERT [dbo].[Chapter] ([Id], [NameChapter], [IdSubject], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'Chuong 2', 1, CAST(N'2023-05-31T17:43:44.4531585' AS DateTime2), CAST(N'2023-05-31T17:43:44.4531585' AS DateTime2), 1, CAST(N'2023-05-31T17:43:51.1382040' AS DateTime2), NULL, NULL)
INSERT [dbo].[Chapter] ([Id], [NameChapter], [IdSubject], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, N'Chương 1', 1, CAST(N'2023-05-31T17:43:56.6734389' AS DateTime2), CAST(N'2023-05-31T17:44:32.8250626' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Chapter] ([Id], [NameChapter], [IdSubject], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4, N'Chương  2', 1, CAST(N'2023-05-31T17:44:08.6204351' AS DateTime2), CAST(N'2023-05-31T17:44:24.4798569' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Chapter] ([Id], [NameChapter], [IdSubject], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5, N'Chương 3', 1, CAST(N'2023-05-31T17:44:12.5263752' AS DateTime2), CAST(N'2023-05-31T17:44:12.5263752' AS DateTime2), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Chapter] OFF
GO
SET IDENTITY_INSERT [dbo].[Lesson] ON 

INSERT [dbo].[Lesson] ([Id], [Content], [Video], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'<p style="box-sizing: inherit; margin-right: 0px; margin-bottom: 1.5em; margin-left: 0px; padding: 0px; border: 0px; color: rgb(58, 58, 58); font-family: -apple-system, system-ui, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; font-size: 17px;">Trong gia đình em, người mà em yêu quý và kính trọng nhất là mẹ.</p><div class="advads-14th-from-bottom" id="advads-473128889" style="box-sizing: inherit; color: rgb(58, 58, 58); font-family: -apple-system, system-ui, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; font-size: 17px;"></div><p style="box-sizing: inherit; margin-right: 0px; margin-bottom: 1.5em; margin-left: 0px; padding: 0px; border: 0px; color: rgb(58, 58, 58); font-family: -apple-system, system-ui, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; font-size: 17px;">Năm nay, mẹ ba sáu tuổi. Dáng người thon thả. Mái tóc dài mượt mà và óng ả .Khuôn mặt trái xoan .Đôi mắt mẹ sáng long lanh như ngọn đuốc dõi theo từng bước đi của em. Môi mẹ đỏ tươi, luôn in lại những nụ cười rạng rỡ. Làn da của mẹ trắng mịn như được thoa một lớp phấn. Những hôm em ốm, nhờ có bàn tay mẹ chăm sóc mà em đã nhanh khỏi để đến trường.</p><p style="box-sizing: inherit; margin-right: 0px; margin-bottom: 1.5em; margin-left: 0px; padding: 0px; border: 0px; color: rgb(58, 58, 58); font-family: -apple-system, system-ui, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; font-size: 17px;">Có mẹ, em thấy ấm lòng. Em rất kính trọng mẹ em.</p>', NULL, 5, CAST(N'2023-05-31T17:45:08.5108846' AS DateTime2), CAST(N'2023-05-31T17:45:08.5108846' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Lesson] ([Id], [Content], [Video], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'<p style="background-repeat: no-repeat; padding: 0px; margin-right: 0px; margin-bottom: 16px; margin-left: 0px; color: rgba(0, 0, 0, 0.87); font-family: &quot;Times New Roman&quot;, sans-serif; font-size: 20px; text-align: justify;">Em được bà nội tặng cho một con mèo. Tên của nó là Mít Ướt. Chú mèo của em nặng khoảng ba ki-lô-gam. Thân hình trông khá mập mạp. Chiếc đầu tròn với đôi tai hình tam giác. Chiếc mũi hồng lúc nào cũng ươn ướt. Cái miệng với những chiếc răng nhọn. Bộ ria mép màu đen, rất dài. Bốn cái chân nhỏ nhưng có những chiếc móng sắc nhọn. Mít Ướt là một chú mèo nghịch ngợm. Mỗi khi rảnh rỗi, em lại chơi với nó. Em rất yêu quý chú mèo của mình.</p><div><br></div>', NULL, 4, CAST(N'2023-05-31T18:20:48.4847559' AS DateTime2), CAST(N'2023-05-31T18:20:48.4847559' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Lesson] ([Id], [Content], [Video], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, N'<p style="margin-right: 0px; margin-bottom: 24px; margin-left: 0px; color: rgb(51, 51, 51); font-family: &quot;Open Sans&quot;, sans-serif; text-align: justify;">Trong gia đình em có 4 người đó là bố, mẹ, em và em trai của em. Mới đây, gia đình em kết nạp thêm một người bạn nhỏ nữa là một chú chó nhỏ vô cùng đáng yêu. Em đã đặt tên cho&nbsp;<span style="font-weight: bolder;">chú chó</span>&nbsp;của mình là Đô Đô.</p><div class="ed0239d4beb563df94ec0e796abd5700" data-index="2" style="color: rgb(51, 51, 51); font-family: &quot;Open Sans&quot;, sans-serif; float: none; margin: 5px 0px; text-align: center;"></div><p style="margin-right: 0px; margin-bottom: 24px; margin-left: 0px; color: rgb(51, 51, 51); font-family: &quot;Open Sans&quot;, sans-serif; text-align: justify;">Từ ngày có Đô Đô, em chẳng muốn đi đâu chơi cả mà chỉ thích ở trong nhà với chú. Trừ những lúc đi học, thì gần như lúc nào em và chú cũng quấn quýt bên nhau. Đô Đô có bộ lông màu đen bóng. Mỗi lần em vuốt ve chú lại có cảm giác trơn tuột vì bộ lông của chú quá mềm mại. Chúng không dài nhưng thẳng tắp. Mỗi khi nằm ngủ, chú thường hay cuộn tròn người lại. Lúc ấy nhìn chú tròn vo như quả bóng. Hai cái tai của Đô Đô lúc nào cũng vểnh lên lắng nghe. Đô Đô có cái mõm dài nhưng cái mũi thì nhỏ xíu. Vậy mà chú vẫn có thể đánh hơi một cách rất cừ.</p><p style="margin-right: 0px; margin-bottom: 24px; margin-left: 0px; color: rgb(51, 51, 51); font-family: &quot;Open Sans&quot;, sans-serif; text-align: justify;">Mỗi tối,&nbsp;<span style="font-weight: bolder;">Đô Đô có nhiệm vụ phải canh gác cho ngôi nhà</span>&nbsp;của em. Vì vậy mà bố mẹ em đã chuẩn bị cho chú một ngôi nhà nhỏ riêng. Bên trong đó có sẵn một cái chăn cũ để chú nằm trong đỡ lạnh. Có lần trong đêm, Đô Đô sủa rất nhiều. Sau đó bố em đã tỉnh dậy và ra xem, thì ra là có người đang đi lại rình mò xung quanh nhà em. Nhìn thấy bố, người đó sợ hãi và bỏ đi.</p>', NULL, 3, CAST(N'2023-05-31T18:21:25.7305622' AS DateTime2), CAST(N'2023-05-31T18:21:25.7305622' AS DateTime2), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Lesson] OFF
GO
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1001, N'VIEW_LIST', N'User', N'Xem danh sách tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1002, N'VIEW_DETAIL', N'User', N'Xem chi tiết tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1003, N'CREATE', N'User', N'Thêm tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1004, N'UPDATE', N'User', N'Sửa tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1005, N'VIEW_LIST', N'User', N'Đổi mật khẩu tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1006, N'VIEW_LIST', N'User', N'khóa tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1007, N'VIEW_LIST', N'User', N'Mở khóa tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1008, N'DELETE', N'User', N'Xóa tài khoản', N'Quản lý tài khoản', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2001, N'VIEW_LIST', N'Answer', N'Xem danh sách câu hỏi', N'Quản lý câu hỏi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2002, N'VIEW_DETAIL', N'Answer', N'Xem chi tiết câu hỏi', N'Quản lý câu hỏi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2003, N'CREATE', N'Answer', N'Thêm câu hỏi', N'Quản lý câu hỏi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2004, N'UPDATE', N'Answer', N'Sửa câu hỏi', N'Quản lý câu hỏi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2008, N'DELETE', N'Answer', N'Xóa câu hỏi', N'Quản lý câu hỏi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3001, N'VIEW_LIST', N'CategoryNew', N'Xem danh sách thể loại tin tức', N'Quản lý thể loại tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3003, N'CREATE', N'CategoryNew', N'Thêm thể loại tin tức', N'Quản lý thể loại tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3004, N'UPDATE', N'CategoryNew', N'Sửa thể loại tin tức', N'Quản lý thể loại tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3008, N'DELETE', N'CategoryNew', N'Xóa thể loại tin tức', N'Quản lý thể loại tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4001, N'VIEW_LIST', N'CategorySub', N'Xem danh sách danh mục', N'Quản lý danh mục', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4003, N'CREATE', N'CategorySub', N'Thêm danh mục', N'Quản lý danh mục', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4004, N'UPDATE', N'CategorySub', N'Sửa danh mục', N'Quản lý danh mục', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4008, N'DELETE', N'CategorySub', N'Xóa danh mục', N'Quản lý danh mục', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5001, N'VIEW_LIST', N'Chapter', N'Xem danh sách chương của bài học', N'Quản lý chương của bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5002, N'VIEW_DETAIL', N'Chapter', N'Xem chi tiết chương của bài học', N'Quản lý chương của bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5003, N'CREATE', N'Chapter', N'Thêm chương của bài học', N'Quản lý chương của bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5004, N'UPDATE', N'Chapter', N'Sửa chương của bài học', N'Quản lý chương của bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5008, N'DELETE', N'Chapter', N'Xóa chương của bài học', N'Quản lý chương của bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6001, N'VIEW_LIST', N'Lesson', N'Xem danh sách bài học', N'Quản lý bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6002, N'VIEW_DETAIL', N'Lesson', N'Xem chi tiết bài học', N'Quản lý bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6003, N'CREATE', N'Lesson', N'Thêm bài học', N'Quản lý bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6004, N'UPDATE', N'Lesson', N'Sửa bài học', N'Quản lý bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6008, N'DELETE', N'Lesson', N'Xóa bài học', N'Quản lý bài học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7001, N'VIEW_LIST', N'Report', N'Xem danh sách phản hồi', N'Quản lý phản hồi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7002, N'VIEW_DETAIL', N'Report', N'Xem chi tiết phản hồi', N'Quản lý phản hồi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7008, N'DELETE', N'Report', N'Xóa phản hồi', N'Quản lý phản hồi', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8001, N'VIEW_LIST', N'Subject', N'Xem danh sách môn học', N'Quản lý môn học ', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8002, N'VIEW_DETAIL', N'Subject', N'Xem chi tiết môn học', N'Quản lý môn học ', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8003, N'CREATE', N'Subject', N'Thêm môn học', N'Quản lý môn học ', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8004, N'UPDATE', N'Subject', N'Sửa môn học', N'Quản lý môn học ', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8008, N'DELETE', N'Subject', N'Xóa môn học', N'Quản lý môn học ', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9001, N'VIEW_LIST', N'News', N'Xem danh sách tin tức', N'Quản lý tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9002, N'VIEW_DETAIL', N'News', N'Xem chi tiết tin tức', N'Quản lý tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9003, N'CREATE', N'News', N'Thêm tin tức', N'Quản lý tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9004, N'UPDATE', N'News', N'Sửa tin tức', N'Quản lý tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9008, N'DELETE', N'News', N'Xóa tin tức', N'Quản lý tin tức', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9101, N'VIEW_LIST', N'Test', N'Xem danh sách bài kiểm tra', N'Quản lý bài kiểm tra', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9102, N'VIEW_DETAIL', N'Test', N'Xem chi tiết bài kiểm tra', N'Quản lý bài kiểm tra', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9103, N'CREATE', N'Test', N'Thêm bài kiểm tra', N'Quản lý bài kiểm tra', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9104, N'UPDATE', N'Test', N'Sửa bài kiểm tra', N'Quản lý bài kiểm tra', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9108, N'DELETE', N'Test', N'Xóa bài kiểm tra', N'Quản lý bài kiểm tra', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9201, N'VIEW_LIST', N'Role', N'Xem danh sách quyền', N'Quản lý phân quyền', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9202, N'VIEW_DETAIL', N'Role', N'Xem chi tiết quyền', N'Quản lý phân quyền', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9203, N'CREATE', N'Role', N'Thêm quyền', N'Quản lý phân quyền', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9204, N'UPDATE', N'Role', N'Sửa quyền', N'Quản lý phân quyền', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9208, N'DELETE', N'Role', N'Xóa quyền', N'Quản lý phân quyền', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9301, N'VIEW_LIST', N'PurchasedCourse', N'Xem danh sách khóa học', N'Quản lý mua khóa học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9302, N'VIEW_DETAIL', N'PurchasedCourse', N'Xem chi tiết khóa học', N'Quản lý mua khóa học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[MstPerMission] ([Id], [Code], [Table], [Desc], [GroupName], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9303, N'CREATE', N'PurchasedCourse', N'Mua khóa học', N'Quản lý mua khóa học', CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([Id], [Title], [Description], [pathImg], [IdCategoryNew], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'Tin nóng tháng 1', N'<p>test nè</p>', N'quan-baggy-nam-80011-06-2023-10-36-06-658.jpg', 1, CAST(N'2023-06-11T10:36:06.6839692' AS DateTime2), CAST(N'2023-06-11T10:36:06.6839692' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[News] ([Id], [Title], [Description], [pathImg], [IdCategoryNew], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'tiêu đề', N'<p>1 23 bốn năm sáu</p>', N'quan-baggy-nam-80011-06-2023-10-36-27-361.jpg', 1, CAST(N'2023-06-11T10:36:27.3713439' AS DateTime2), CAST(N'2023-06-11T10:36:27.3713439' AS DateTime2), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchasedCourse] ON 

INSERT [dbo].[PurchasedCourse] ([Id], [IdSub], [IdUser], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Price]) VALUES (12, 10, 1, CAST(N'2023-06-21T18:29:08.5735384' AS DateTime2), CAST(N'2023-06-21T18:29:08.5735384' AS DateTime2), 1, NULL, NULL, NULL, 600000)
INSERT [dbo].[PurchasedCourse] ([Id], [IdSub], [IdUser], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Price]) VALUES (13, 8, 1, CAST(N'2023-06-22T11:58:42.3194895' AS DateTime2), CAST(N'2023-06-22T11:58:42.3194895' AS DateTime2), 1, NULL, NULL, NULL, 200000)
INSERT [dbo].[PurchasedCourse] ([Id], [IdSub], [IdUser], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Price]) VALUES (14, 9, 4, CAST(N'2023-06-22T13:28:34.8666171' AS DateTime2), CAST(N'2023-06-22T13:28:34.8666171' AS DateTime2), 4, NULL, NULL, NULL, 500000)
INSERT [dbo].[PurchasedCourse] ([Id], [IdSub], [IdUser], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Price]) VALUES (15, 10, 4, CAST(N'2023-06-22T13:40:04.3925383' AS DateTime2), CAST(N'2023-06-22T13:40:04.3925383' AS DateTime2), 4, NULL, NULL, NULL, 600000)
INSERT [dbo].[PurchasedCourse] ([Id], [IdSub], [IdUser], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder], [Price]) VALUES (16, 8, 4, CAST(N'2023-06-22T13:44:54.5797994' AS DateTime2), CAST(N'2023-06-22T13:44:54.5797994' AS DateTime2), 4, NULL, NULL, NULL, 200000)
SET IDENTITY_INSERT [dbo].[PurchasedCourse] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [RoleName], [Description], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'Quản trị hệ thống', N'Quản trị toàn bộ hệ thống', CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[Role] ([Id], [RoleName], [Description], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'Khách hàng', N'Tài khoản do khách hàng tạo ngoài trang client', CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[RolePermission] ON 

INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, 1, 1001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, 1, 1002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, 1, 1003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4, 1, 1004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5, 1, 1005, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6, 1, 1006, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7, 1, 1007, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8, 1, 1008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9, 1, 2001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (10, 1, 2002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (11, 1, 2003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (12, 1, 2004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (13, 1, 2008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (14, 1, 3001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (15, 1, 3003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (16, 1, 3004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (17, 1, 3008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (18, 1, 4001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (19, 1, 4003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (20, 1, 4004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (21, 1, 4008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (22, 1, 5002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (23, 1, 5001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (24, 1, 5003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (25, 1, 5004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (26, 1, 5008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (27, 1, 6002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (28, 1, 6001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (29, 1, 6003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (30, 1, 6004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (31, 1, 6008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (32, 1, 7001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (33, 1, 7002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (34, 1, 7008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (35, 1, 8002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (36, 1, 8001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (37, 1, 8003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (38, 1, 8004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (39, 1, 8008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (40, 1, 9001, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (41, 1, 9002, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (42, 1, 9003, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (43, 1, 9004, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (44, 1, 9008, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (45, 1, 9101, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (46, 1, 9102, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (47, 1, 9103, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (48, 1, 9104, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (49, 1, 9108, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (50, 1, 9201, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (51, 1, 9202, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (52, 1, 9203, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (53, 1, 9204, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (54, 1, 9208, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (55, 2, 9301, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (56, 2, 9302, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MStPermissionId], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (57, 2, 9303, CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[RolePermission] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'Môn Tiếng Việt', 1, CAST(N'2023-05-29T14:56:52.6927872' AS DateTime2), CAST(N'2023-05-29T14:56:52.6927872' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'Môn Tiếng Việt', 2, CAST(N'2023-05-29T15:23:54.0733975' AS DateTime2), CAST(N'2023-05-29T15:23:54.0733975' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, N'Môn toán', 2, CAST(N'2023-05-29T15:43:13.6771418' AS DateTime2), CAST(N'2023-05-29T15:43:13.6771418' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4, N'Chương 1', 10, CAST(N'2023-06-04T18:32:19.5800487' AS DateTime2), CAST(N'2023-06-04T18:32:19.5800487' AS DateTime2), 1, CAST(N'2023-06-04T18:33:14.6989000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5, N'Môn Tiếng Việt', 10, CAST(N'2023-06-04T18:32:54.4929698' AS DateTime2), CAST(N'2023-06-04T18:32:54.4929698' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6, N'Môn toán', 10, CAST(N'2023-06-04T18:33:22.3719388' AS DateTime2), CAST(N'2023-06-04T18:33:22.3719388' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7, N'Môn Tiếng Việt', 9, CAST(N'2023-06-04T18:34:08.1582239' AS DateTime2), CAST(N'2023-06-04T18:34:08.1582239' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (8, N'Môn toán', 9, CAST(N'2023-06-04T18:34:16.8253291' AS DateTime2), CAST(N'2023-06-04T18:34:16.8253291' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (9, N'Môn Ngữ Văn', 11, CAST(N'2023-07-05T13:18:36.3170467' AS DateTime2), CAST(N'2023-07-05T13:18:36.3170467' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [NameSubject], [IdCategorySub], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (10, N'Môn toán đại số', 11, CAST(N'2023-07-05T13:18:51.8993624' AS DateTime2), CAST(N'2023-07-05T13:18:51.8993624' AS DateTime2), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Test] ON 

INSERT [dbo].[Test] ([Id], [Question], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'Trong gia đình, bé yêu quý nhất là ai', 1, CAST(N'2023-05-31T17:45:44.3801633' AS DateTime2), CAST(N'2023-05-31T17:45:44.3801633' AS DateTime2), 1, CAST(N'2023-05-31T22:42:54.7299198' AS DateTime2), NULL, NULL)
INSERT [dbo].[Test] ([Id], [Question], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'Chú chó nhà em tê là gì', 3, CAST(N'2023-05-31T18:22:09.7171348' AS DateTime2), CAST(N'2023-05-31T18:22:09.7171348' AS DateTime2), 1, CAST(N'2023-05-31T22:43:02.9099748' AS DateTime2), NULL, NULL)
INSERT [dbo].[Test] ([Id], [Question], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, N'Con mèo nặng bao nhiêu kí', 2, CAST(N'2023-05-31T18:23:09.6013033' AS DateTime2), CAST(N'2023-05-31T18:23:09.6013033' AS DateTime2), 1, CAST(N'2023-05-31T18:24:51.5857872' AS DateTime2), NULL, NULL)
INSERT [dbo].[Test] ([Id], [Question], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (5, N'Trong gia đình, bé yêu quý nhất là ai', 5, CAST(N'2023-05-31T22:57:05.5929272' AS DateTime2), CAST(N'2023-05-31T22:57:05.5929272' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Test] ([Id], [Question], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (6, N'Chú chó nhà em tên là gì', 3, CAST(N'2023-05-31T22:57:43.5057593' AS DateTime2), CAST(N'2023-05-31T22:57:43.5057593' AS DateTime2), 1, NULL, NULL, NULL)
INSERT [dbo].[Test] ([Id], [Question], [IdChapter], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (7, N'Làn da của mẹ trắng mịn như  được thoa ', 5, CAST(N'2023-06-01T11:38:19.0118917' AS DateTime2), CAST(N'2023-06-01T11:38:19.0118917' AS DateTime2), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Test] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [UserName], [PasswordHash], [PasswordSalt], [Gmail], [PhoneNumber], [IdRole], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (1, N'admin', 0x610D11865478A918FEC3127183629CBF560E3349E13D86AF5F5EBB9778EDA6B68D2EAF3EF90DBCCD3281AC85FE48AFC6411C82A932739A982660509116E93916, 0xF35D590A1BCC535B4D61488AD63DA2DC5824ACD2342BF26BB4A413C0D745EABC4BCCE70C381E523593B1926778E69C39FDFB337EE02B0D42AD57E6CCB21CE5C845F50FBE854FB3FEB201826AFD069AF13A9984E7777DC9BFFC192E6D13F4582CD6312108E91291934D7595532EE4C29FA98F4AA78AE11A5349235BBE839C47C4, N'admin_test@gmail.com', N'0928666158', 1, CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-10T00:00:00.0000000' AS DateTime2), -1, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [UserName], [PasswordHash], [PasswordSalt], [Gmail], [PhoneNumber], [IdRole], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (2, N'bao2811', 0x6C5C3263BDC166A528C124953B27A922A3D492E016B685217DF497FBA7AD3DB0274C5CC72960C28628F8957066F12C148092004633EA0C911C5894353F27FABE, 0xBB0F511F9720B4F65AC898723D3C932F8326725B6559233F0EFCC773F95C66762833480AFE876DF4F5F2E86743E6FE03BEA82B9E4D58921D28CCA83C229F5681B7322503EF03D5550750FF9B741E21DDA6726D8C3E4D34A79E7CADEA205110A99A928E84E8463BD3505078156DFE0DCD71D75E881C9464F4D0D9625CB4FAB3D2, N'letranhoaibao2811@gmail.com', N'0522995259', 2, CAST(N'2023-05-31T15:55:49.4410305' AS DateTime2), CAST(N'2023-05-31T15:55:49.4410305' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [UserName], [PasswordHash], [PasswordSalt], [Gmail], [PhoneNumber], [IdRole], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (3, N'sang1809', 0x6B790727CEF844F74D2C963C9885A2DBFEC1E3828F0031D8689471DDB4EFBD5E701C5E8165DD14C63B9C8C015273ED04A465DE1663C23F8A5FFE385AA42F8E24, 0xB5C262E114D27A627073176BE4487371C690111A27156179F1C2870AD363314F9B68CBC6C74BF3A4EB924221767E37CEC16F24A05C259C773D80BBACACC693B491B432A646A95AF89690855B341079850ACE2AD737A6A18549735DBE51F09319FC8E1DCA08D87F4CB62C3A672A772FCE8B097BE832DB1B715C4575547EEBDE31, N'letranhoaibao@gmail.com', N'1111111111', 2, CAST(N'2023-06-20T15:35:35.1606041' AS DateTime2), CAST(N'2023-06-20T15:35:35.1606041' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [UserName], [PasswordHash], [PasswordSalt], [Gmail], [PhoneNumber], [IdRole], [CreateAt], [UpdateAt], [CreateBy], [DeleteAt], [DetleteBy], [DislayOrder]) VALUES (4, N'bao281101', 0x0A9899C592553C60CC5FA925E31F75AB7C0D5C2D9D34B95E6CAC260B09F8262A4D937D8019B407AEF4828E9E1C70071B1784F1EDBBBB68FDA7DB2E1C68C148A8, 0x4328DC3B5BE14D6E5ECDF472C7BCC81507C04736E1309B72AE250FFBC866D5B9E79366F2E5D95EBA721A288258EBCEEC98FC54A51DB77B6552CD615521EA6181B31B0C4AC05C47535DE6AB6D0636AFA94B3B69B9DE4D7410D2D6AEB73F3A0E380D48FEE06E2314B42B825F8D7AC3D48F816A907D1E7A2726A374DEB67A540E3E, N'bao11a12018@gmail.com', N'0522995259', 2, CAST(N'2023-06-22T13:28:02.0037853' AS DateTime2), CAST(N'2023-06-22T13:28:02.0037853' AS DateTime2), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[CategorySub] ADD  DEFAULT (N'') FOR [Descripstion]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Test_IdQues] FOREIGN KEY([IdQues])
REFERENCES [dbo].[Test] ([Id])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Test_IdQues]
GO
ALTER TABLE [dbo].[Chapter]  WITH CHECK ADD  CONSTRAINT [FK_Chapter_Subject_IdSubject] FOREIGN KEY([IdSubject])
REFERENCES [dbo].[Subject] ([Id])
GO
ALTER TABLE [dbo].[Chapter] CHECK CONSTRAINT [FK_Chapter_Subject_IdSubject]
GO
ALTER TABLE [dbo].[Coment]  WITH CHECK ADD  CONSTRAINT [FK_Coment_Lesson_IdLesson] FOREIGN KEY([IdLesson])
REFERENCES [dbo].[Lesson] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Coment] CHECK CONSTRAINT [FK_Coment_Lesson_IdLesson]
GO
ALTER TABLE [dbo].[Lesson]  WITH CHECK ADD  CONSTRAINT [FK_Lesson_Chapter_IdChapter] FOREIGN KEY([IdChapter])
REFERENCES [dbo].[Chapter] ([Id])
GO
ALTER TABLE [dbo].[Lesson] CHECK CONSTRAINT [FK_Lesson_Chapter_IdChapter]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_CategoryNew_IdCategoryNew] FOREIGN KEY([IdCategoryNew])
REFERENCES [dbo].[CategoryNew] ([Id])
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_CategoryNew_IdCategoryNew]
GO
ALTER TABLE [dbo].[PurchasedCourse]  WITH CHECK ADD  CONSTRAINT [FK_PurchasedCourse_CategorySub_IdSub] FOREIGN KEY([IdSub])
REFERENCES [dbo].[CategorySub] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchasedCourse] CHECK CONSTRAINT [FK_PurchasedCourse_CategorySub_IdSub]
GO
ALTER TABLE [dbo].[PurchasedCourse]  WITH CHECK ADD  CONSTRAINT [FK_PurchasedCourse_User_IdUser] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchasedCourse] CHECK CONSTRAINT [FK_PurchasedCourse_User_IdUser]
GO
ALTER TABLE [dbo].[RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_RolePermission_MstPerMission_MStPermissionId] FOREIGN KEY([MStPermissionId])
REFERENCES [dbo].[MstPerMission] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolePermission] CHECK CONSTRAINT [FK_RolePermission_MstPerMission_MStPermissionId]
GO
ALTER TABLE [dbo].[RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_RolePermission_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolePermission] CHECK CONSTRAINT [FK_RolePermission_Role_RoleId]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_CategorySub_IdCategorySub] FOREIGN KEY([IdCategorySub])
REFERENCES [dbo].[CategorySub] ([Id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_CategorySub_IdCategorySub]
GO
ALTER TABLE [dbo].[Test]  WITH CHECK ADD  CONSTRAINT [FK_Test_Chapter_IdChapter] FOREIGN KEY([IdChapter])
REFERENCES [dbo].[Chapter] ([Id])
GO
ALTER TABLE [dbo].[Test] CHECK CONSTRAINT [FK_Test_Chapter_IdChapter]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_IdRole] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role_IdRole]
GO
