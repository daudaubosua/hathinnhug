USE [master]
GO
/****** Object:  Database [quanlihocsinh]    Script Date: 5/31/2017 7:05:39 PM ******/
CREATE DATABASE [quanlihocsinh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlihocsinh', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\quanlihocsinh.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlihocsinh_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\quanlihocsinh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlihocsinh] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlihocsinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlihocsinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlihocsinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlihocsinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlihocsinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlihocsinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlihocsinh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlihocsinh] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [quanlihocsinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlihocsinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlihocsinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlihocsinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlihocsinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlihocsinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlihocsinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlihocsinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlihocsinh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quanlihocsinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlihocsinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlihocsinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlihocsinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlihocsinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlihocsinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlihocsinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlihocsinh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quanlihocsinh] SET  MULTI_USER 
GO
ALTER DATABASE [quanlihocsinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlihocsinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlihocsinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlihocsinh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [quanlihocsinh]
GO
/****** Object:  StoredProcedure [dbo].[sp_hs_them]    Script Date: 5/31/2017 7:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_hs_them]
@ma int, @hoten nvarchar(50), @ngaysinh datetime, @lop int, @hocluc nvarchar(50),
@hanhkiem nvarchar(50), @chucvu nvarchar(50), @giaovienchunhiem int, @diachi nvarchar(100)
as begin
	insert into hocsinh (ma, hoten, ngaysinh, lop, hocluc, hanhkiem, chucvu, 
		giaovienchunhiem, diachi) values (@ma, @hoten, @ngaysinh, @lop, @hocluc,
		@hanhkiem, @chucvu, @giaovienchunhiem, @diachi)
end
GO
/****** Object:  Table [dbo].[bomon]    Script Date: 5/31/2017 7:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bomon](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
	[gioithieu] [nvarchar](max) NULL,
	[sodienthoai] [varchar](20) NULL,
	[diachi] [nvarchar](max) NULL,
	[email] [nvarchar](20) NULL,
 CONSTRAINT [PK_bomon] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[giaovien]    Script Date: 5/31/2017 7:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[giaovien](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[dienthoai] [int] NULL,
	[giangday] [int] NULL,
	[bomonma] [int] NULL,
	[chunhiemlop] [int] NULL,
	[luongcoban] [decimal](18, 0) NULL,
 CONSTRAINT [PK_giaovien] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hocsinh]    Script Date: 5/31/2017 7:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hocsinh](
	[ma] [int] NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[lop] [int] NULL,
	[hocluc] [nvarchar](20) NULL,
	[hanhkiem] [nvarchar](20) NULL,
	[chucvu] [nvarchar](50) NULL,
	[giaovienchunhiem] [int] NULL,
	[diachi] [varchar](max) NULL,
 CONSTRAINT [PK_hocsinh] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 5/31/2017 7:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOGIN](
	[USERNAME] [varchar](50) NOT NULL,
	[PASSWORD] [varchar](50) NULL,
 CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lophoc]    Script Date: 5/31/2017 7:05:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lophoc](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
	[cahoc] [nvarchar](50) NULL,
	[siso] [int] NULL,
	[giaovienday] [int] NULL,
 CONSTRAINT [PK_lophoc] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[giaovien]  WITH CHECK ADD  CONSTRAINT [FK_giaovien_bomon] FOREIGN KEY([bomonma])
REFERENCES [dbo].[bomon] ([ma])
GO
ALTER TABLE [dbo].[giaovien] CHECK CONSTRAINT [FK_giaovien_bomon]
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD  CONSTRAINT [FK_hocsinh_giaovien] FOREIGN KEY([giaovienchunhiem])
REFERENCES [dbo].[giaovien] ([ma])
GO
ALTER TABLE [dbo].[hocsinh] CHECK CONSTRAINT [FK_hocsinh_giaovien]
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD  CONSTRAINT [FK_hocsinh_lophoc] FOREIGN KEY([lop])
REFERENCES [dbo].[lophoc] ([ma])
GO
ALTER TABLE [dbo].[hocsinh] CHECK CONSTRAINT [FK_hocsinh_lophoc]
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD  CONSTRAINT [FK_lophoc_giaovien] FOREIGN KEY([giaovienday])
REFERENCES [dbo].[giaovien] ([ma])
GO
ALTER TABLE [dbo].[lophoc] CHECK CONSTRAINT [FK_lophoc_giaovien]
GO
USE [master]
GO
ALTER DATABASE [quanlihocsinh] SET  READ_WRITE 
GO
