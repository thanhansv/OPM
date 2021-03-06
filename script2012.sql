USE [master]
GO
/****** Object:  Database [OpmDB]    Script Date: 10/22/2021 9:15:30 AM ******/
CREATE DATABASE [OpmDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OpmDB', FILENAME = N'D:\OPM\DataSQL\OpmDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OpmDB_log', FILENAME = N'D:\OPM\DataSQL\OpmDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OpmDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OpmDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OpmDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OpmDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OpmDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OpmDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [OpmDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OpmDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OpmDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OpmDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OpmDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OpmDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OpmDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OpmDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OpmDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OpmDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OpmDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OpmDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OpmDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OpmDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OpmDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OpmDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OpmDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OpmDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OpmDB] SET  MULTI_USER 
GO
ALTER DATABASE [OpmDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OpmDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OpmDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OpmDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [OpmDB]
GO
/****** Object:  Table [dbo].[Case]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Case](
	[id] [varchar](10) NOT NULL,
	[id_packagelist] [varchar](10) NULL,
	[make_in] [varchar](20) NULL,
	[dimension] [varchar](20) NULL,
	[weight] [int] NULL,
	[volume] [int] NULL,
 CONSTRAINT [PK_Case] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CatalogAdmin]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatalogAdmin](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[ctlID] [varchar](100) NULL,
	[ctlname] [varchar](100) NULL,
	[ctlparent] [varchar](100) NULL,
UNIQUE NONCLUSTERED 
(
	[ctlID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[id] [varchar](50) NOT NULL,
	[namecontract] [nvarchar](250) NULL,
	[codeaccouting] [varchar](250) NULL,
	[datesigned] [date] NULL,
	[typecontract] [nvarchar](250) NULL,
	[durationcontract] [int] NULL,
	[activedate] [date] NULL,
	[valuecontract] [float] NULL,
	[durationpo] [int] NULL,
	[id_siteA] [nvarchar](250) NULL,
	[id_siteB] [nvarchar](250) NULL,
	[phuluc] [varchar](250) NULL,
	[vbgurantee] [varchar](250) NULL,
	[KHMS] [nvarchar](250) NULL,
	[experationDate] [date] NULL,
	[blvalue] [int] NULL,
	[garanteeCreatedDate] [date] NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract_Goods]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract_Goods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idContract] [varchar](50) NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[origin] [nvarchar](50) NULL,
	[manufacturer] [nvarchar](100) NULL,
	[code] [nvarchar](100) NULL,
	[unit] [nvarchar](20) NULL,
	[priceUnit] [float] NULL,
	[quantity] [int] NULL,
	[note] [nvarchar](250) NULL,
	[license] [nvarchar](200) NULL,
	[name1] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Contract_Goods_Unique] UNIQUE NONCLUSTERED 
(
	[idContract] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery_PO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery_PO](
	[Delivery_PO_Id] [int] IDENTITY(1,1) NOT NULL,
	[NumberConfirmPO] [nvarchar](250) NULL,
	[Province] [nvarchar](250) NULL,
	[Count_PO] [int] NULL,
	[Number_PO] [int] NULL,
	[Date_Delivery] [date] NULL,
	[id_po] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Delivery_PO_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryPlan]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryPlan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPO_Thanh] [varchar](30) NOT NULL,
	[province] [nvarchar](50) NULL,
	[phase] [int] NULL,
	[expectedQuantity] [int] NULL,
	[expectedDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Device]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device](
	[serial] [varchar](10) NOT NULL,
	[id_storage] [varchar](10) NULL,
	[MAC] [varchar](20) NULL,
	[serial_gpon] [varchar](10) NULL,
	[device_name] [varchar](50) NULL,
	[note] [varchar](50) NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[serial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DP]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DP](
	[id] [varchar](10) NOT NULL,
	[id_po] [varchar](30) NULL,
	[id_contract] [varchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[dateopen] [date] NULL,
	[datedeliver] [date] NULL,
	[mskt] [varchar](10) NULL,
	[note] [nvarchar](50) NULL,
 CONSTRAINT [PK_DP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListExpected_DP]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListExpected_DP](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProvinceName] [nvarchar](max) NULL,
	[NumberDevice] [int] NULL,
	[id_dp] [nvarchar](150) NULL,
	[type] [nvarchar](150) NULL,
	[id_po] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListExpected_PO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListExpected_PO](
	[id_po] [varchar](30) NOT NULL,
	[id_province] [varchar](20) NOT NULL,
	[numberofdevice] [int] NULL,
	[nameofdevice] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NTKT]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NTKT](
	[id] [nvarchar](20) NOT NULL,
	[id_po] [varchar](30) NULL,
	[numberofdevice] [int] NULL,
	[deliver_date_expected] [date] NULL,
	[email_request_status] [varchar](10) NULL,
	[create_date] [date] NULL,
	[numberofdevice2] [int] NULL,
	[number] [int] NULL,
	[date_BBNTKT] [date] NULL,
	[date_BBKTKT] [date] NULL,
	[date_CNBQPM] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NTLicense]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NTLicense](
	[id] [varchar](10) NOT NULL,
	[id_ntkt] [varchar](10) NOT NULL,
	[vdb_naplicense] [varchar](50) NULL,
	[vb_ntlicense] [varchar](50) NULL,
 CONSTRAINT [PK_NTLicense] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[id_ntkt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackageList]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackageList](
	[id] [varchar](10) NOT NULL,
	[id_dp] [varchar](10) NULL,
	[date_deliver] [date] NULL,
	[type] [varchar](10) NULL,
	[target_address] [varchar](50) NULL,
	[note] [varchar](50) NULL,
 CONSTRAINT [PK_PackageList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuLucSerial]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuLucSerial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Serial] [nvarchar](250) NULL,
	[id_dp] [nvarchar](50) NULL,
	[id_po] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PO](
	[id] [varchar](30) NOT NULL,
	[id_contract] [varchar](50) NOT NULL,
	[po_number] [varchar](10) NULL,
	[numberofdevice] [float] NULL,
	[datecreated] [date] NULL,
	[priceunit] [int] NULL,
	[dateconfirm] [date] NULL,
	[dateperform] [date] NULL,
	[dateline] [date] NULL,
	[targetdeliveradd] [nchar](10) NULL,
	[email_BLBH_status] [varchar](10) NULL,
	[email_BLTH_status] [varchar](10) NULL,
	[totalvalue] [float] NULL,
	[tupo] [int] NULL,
	[tupo_datecreated] [date] NULL,
	[confirmpo_number] [varchar](20) NULL,
	[confirmpo_datecreated] [date] NULL,
	[bltupo] [int] NULL,
	[bltupo_datecreated] [date] NULL,
	[confirmpo_dateactive] [date] NULL,
 CONSTRAINT [PK_PO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PO_Thanh]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PO_Thanh](
	[id] [varchar](30) NOT NULL,
	[idContract] [varchar](50) NOT NULL,
	[poName] [varchar](10) NULL,
	[numberOfDevice] [float] NULL,
	[signedDate] [date] NULL,
	[confirmRequestDate] [date] NULL,
	[defaultPerformDate] [date] NULL,
	[performDate] [date] NULL,
	[deadline] [date] NULL,
	[totalValue] [float] NULL,
	[idConfirm] [varchar](20) NULL,
	[confirmCreatedDate] [date] NULL,
	[advancePercentage] [int] NULL,
	[advanceCreatedDate] [date] NULL,
	[advanceGuaranteePercentage] [int] NULL,
	[advanceGuaranteeCreatedDate] [date] NULL,
	[idAdvanceRequest] [varchar](20) NULL,
	[advanceRequestDate] [date] NULL,
 CONSTRAINT [PK_PO_Thanh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameProvinces] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Site]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Site](
	[id] [nvarchar](250) NOT NULL,
	[idVNPT] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NULL,
	[headquater] [nvarchar](250) NULL,
	[address] [nvarchar](250) NULL,
	[phonenumber] [varchar](20) NULL,
	[fax] [varchar](20) NULL,
	[tax] [varchar](20) NULL,
	[account] [varchar](20) NULL,
	[representative1] [nvarchar](50) NULL,
	[position1] [nvarchar](50) NULL,
	[proxy1] [nvarchar](50) NULL,
	[representative2] [nvarchar](50) NULL,
	[position2] [nvarchar](50) NULL,
	[proxy2] [nvarchar](50) NULL,
	[representative3] [nvarchar](50) NULL,
	[position3] [nvarchar](50) NULL,
	[proxy3] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[idVNPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Site_Info]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Site_Info](
	[id] [nvarchar](250) NULL,
	[type] [varchar](10) NULL,
	[headquater_info] [nvarchar](250) NULL,
	[address] [nvarchar](250) NULL,
	[phonenumber] [varchar](20) NULL,
	[tin] [varchar](20) NULL,
	[account] [varchar](20) NULL,
	[representative] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[id] [varchar](10) NOT NULL,
	[id_case] [varchar](10) NULL,
 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VBConfirmPO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VBConfirmPO](
	[id_ConfirmPO] [varchar](50) NULL,
	[id_po] [varchar](30) NULL,
	[vb_ConfirmPO] [varchar](250) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT ('111-2020/CUVT-ANSV/DTRR-KHMS') FOR [idContract]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT (N'Thiết bị đầu cuối ONT loại  (2FE/GE + Wifi Dualband) tương thích hệ thống GPON cùng đầy đủ license và phụ kiện kèm theo (không bao gồm dây nhảy quang, bản quyền Multicast)') FOR [name]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT ('Vi?t Nam') FOR [origin]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT ('VNPT Technology') FOR [manufacturer]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT (N'Việt Nam/VNPT Technology/iGate GW020-H') FOR [code]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT (N'Bộ') FOR [unit]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT ((0)) FOR [priceUnit]
GO
ALTER TABLE [dbo].[Contract_Goods] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[DeliveryPlan] ADD  DEFAULT ((0)) FOR [phase]
GO
ALTER TABLE [dbo].[DeliveryPlan] ADD  DEFAULT ((0)) FOR [expectedQuantity]
GO
ALTER TABLE [dbo].[DeliveryPlan] ADD  DEFAULT (getdate()) FOR [expectedDate]
GO
ALTER TABLE [dbo].[Site] ADD  DEFAULT (N'Quản lý sử dụng') FOR [type]
GO
ALTER TABLE [dbo].[Site] ADD  DEFAULT (N'Giám đốc') FOR [position1]
GO
ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_Case_PackageList1] FOREIGN KEY([id_packagelist])
REFERENCES [dbo].[PackageList] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Case] CHECK CONSTRAINT [FK_Case_PackageList1]
GO
ALTER TABLE [dbo].[Contract_Goods]  WITH CHECK ADD  CONSTRAINT [FK_Contract] FOREIGN KEY([idContract])
REFERENCES [dbo].[Contract] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contract_Goods] CHECK CONSTRAINT [FK_Contract]
GO
ALTER TABLE [dbo].[DeliveryPlan]  WITH CHECK ADD FOREIGN KEY([idPO_Thanh])
REFERENCES [dbo].[PO_Thanh] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Device]  WITH CHECK ADD  CONSTRAINT [FK_Device_Storage] FOREIGN KEY([id_storage])
REFERENCES [dbo].[Storage] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Device] CHECK CONSTRAINT [FK_Device_Storage]
GO
ALTER TABLE [dbo].[DP]  WITH CHECK ADD  CONSTRAINT [FK_DP_PO] FOREIGN KEY([id_po])
REFERENCES [dbo].[PO] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DP] CHECK CONSTRAINT [FK_DP_PO]
GO
ALTER TABLE [dbo].[ListExpected_PO]  WITH CHECK ADD  CONSTRAINT [fk_PO_ID] FOREIGN KEY([id_po])
REFERENCES [dbo].[PO] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ListExpected_PO] CHECK CONSTRAINT [fk_PO_ID]
GO
ALTER TABLE [dbo].[NTKT]  WITH CHECK ADD  CONSTRAINT [FK_NTKT_PO] FOREIGN KEY([id_po])
REFERENCES [dbo].[PO] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NTKT] CHECK CONSTRAINT [FK_NTKT_PO]
GO
ALTER TABLE [dbo].[PackageList]  WITH CHECK ADD  CONSTRAINT [FK_PackageList_DP] FOREIGN KEY([id_dp])
REFERENCES [dbo].[DP] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PackageList] CHECK CONSTRAINT [FK_PackageList_DP]
GO
ALTER TABLE [dbo].[PO]  WITH CHECK ADD  CONSTRAINT [FK_PO_Contract] FOREIGN KEY([id_contract])
REFERENCES [dbo].[Contract] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PO] CHECK CONSTRAINT [FK_PO_Contract]
GO
ALTER TABLE [dbo].[PO_Thanh]  WITH CHECK ADD  CONSTRAINT [FK_PO_Thanh_Contract] FOREIGN KEY([idContract])
REFERENCES [dbo].[Contract] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PO_Thanh] CHECK CONSTRAINT [FK_PO_Thanh_Contract]
GO
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [FK_Case_PackageList] FOREIGN KEY([id_case])
REFERENCES [dbo].[Case] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [FK_Case_PackageList]
GO
ALTER TABLE [dbo].[VBConfirmPO]  WITH CHECK ADD  CONSTRAINT [FK_VBConfirmPO_PO] FOREIGN KEY([id_po])
REFERENCES [dbo].[PO] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VBConfirmPO] CHECK CONSTRAINT [FK_VBConfirmPO_PO]
GO
/****** Object:  Trigger [dbo].[DeleteCatalogAdmin_After_DeleteContract]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DeleteCatalogAdmin_After_DeleteContract] ON [dbo].[Contract] AFTER DELETE AS 
BEGIN
	DELETE FROM dbo.CatalogAdmin WHERE ctlID IN (SELECT 'Contract_'+Deleted.id FROM Deleted)
END
GO
ALTER TABLE [dbo].[Contract] ENABLE TRIGGER [DeleteCatalogAdmin_After_DeleteContract]
GO
/****** Object:  Trigger [dbo].[InsertCatalogAdmin_After_InsertContract]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsertCatalogAdmin_After_InsertContract] ON [dbo].[Contract] AFTER INSERT AS 
BEGIN
	INSERT INTO dbo.CatalogAdmin
(
    ctlID,
    ctlname
)
VALUES
(   (SELECT 'Contract_'+id FROM INSERTED),
	(SELECT ID FROM INSERTED))
END
GO
ALTER TABLE [dbo].[Contract] ENABLE TRIGGER [InsertCatalogAdmin_After_InsertContract]
GO
/****** Object:  Trigger [dbo].[UpdateCatalogAdmin_After_UpdateContract]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateCatalogAdmin_After_UpdateContract] ON [dbo].[Contract] AFTER UPDATE AS 
BEGIN
	UPDATE dbo.CatalogAdmin
	SET ctlID = (SELECT 'Contract_'+ Inserted.id FROM INSERTED),ctlname = (SELECT Inserted.id FROM INSERTED)
	WHERE ctlID IN (SELECT 'Contract_'+ Deleted.id FROM Deleted)
	UPDATE dbo.CatalogAdmin
	SET ctlparent = (SELECT 'Contract_'+ Inserted.id FROM INSERTED)
	WHERE ctlparent IN (SELECT 'Contract_'+ Deleted.id FROM Deleted)

END
GO
ALTER TABLE [dbo].[Contract] ENABLE TRIGGER [UpdateCatalogAdmin_After_UpdateContract]
GO
/****** Object:  Trigger [dbo].[DeleteCatalogAdmin_After_DeleteNTKT]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DeleteCatalogAdmin_After_DeleteNTKT] ON [dbo].[NTKT] AFTER DELETE AS 
BEGIN
	DELETE FROM dbo.CatalogAdmin WHERE ctlID IN (SELECT 'NTKT_'+Deleted.id FROM Deleted)
END
SELECT * FROM dbo.CatalogAdmin
GO
ALTER TABLE [dbo].[NTKT] ENABLE TRIGGER [DeleteCatalogAdmin_After_DeleteNTKT]
GO
/****** Object:  Trigger [dbo].[InsertCatalogAdmin_After_InsertNTKT]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsertCatalogAdmin_After_InsertNTKT] ON [dbo].[NTKT] AFTER INSERT AS 
BEGIN
	INSERT INTO dbo.CatalogAdmin
(
    ctlID,
    ctlname,
	ctlparent
)
VALUES
(   (SELECT 'NTKT_'+ Inserted.id FROM INSERTED),
	(SELECT 'NTKT'+ CAST(Inserted.number AS VARCHAR(100))  FROM INSERTED),
	(SELECT 'PO_'+Inserted.id_po FROM INSERTED))
END
GO
ALTER TABLE [dbo].[NTKT] ENABLE TRIGGER [InsertCatalogAdmin_After_InsertNTKT]
GO
/****** Object:  Trigger [dbo].[UpdateCatalogAdmin_After_UdateNTKT]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateCatalogAdmin_After_UdateNTKT] ON [dbo].[NTKT] AFTER UPDATE AS 
BEGIN
	UPDATE dbo.CatalogAdmin
	SET ctlname = (SELECT 'NTKT'+ CAST(Inserted.number AS VARCHAR(100)) FROM INSERTED)
	WHERE ctlID IN (SELECT 'NTKT_'+ Inserted.id FROM INSERTED)
END
GO
ALTER TABLE [dbo].[NTKT] ENABLE TRIGGER [UpdateCatalogAdmin_After_UdateNTKT]
GO
/****** Object:  Trigger [dbo].[DeleteCatalogAdmin_After_DeletePO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DeleteCatalogAdmin_After_DeletePO] ON [dbo].[PO] AFTER DELETE AS 
BEGIN
	DELETE FROM dbo.CatalogAdmin WHERE ctlID IN (SELECT 'PO_'+Deleted.id FROM Deleted)
END
GO
ALTER TABLE [dbo].[PO] ENABLE TRIGGER [DeleteCatalogAdmin_After_DeletePO]
GO
/****** Object:  Trigger [dbo].[InsertCatalogAdmin_After_InsertPO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsertCatalogAdmin_After_InsertPO] ON [dbo].[PO] AFTER INSERT AS 
BEGIN
	INSERT INTO dbo.CatalogAdmin
(
    ctlID,
    ctlname,
	ctlparent
)
VALUES
(   (SELECT 'PO_'+Inserted.id FROM INSERTED),
	(SELECT Inserted.po_number FROM INSERTED),
	(SELECT 'Contract_'+Inserted.id_contract FROM INSERTED))
END
GO
ALTER TABLE [dbo].[PO] ENABLE TRIGGER [InsertCatalogAdmin_After_InsertPO]
GO
/****** Object:  Trigger [dbo].[UpdateCatalogAdmin_After_UpdatePO]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateCatalogAdmin_After_UpdatePO] ON [dbo].[PO] AFTER UPDATE AS 
BEGIN
	UPDATE dbo.CatalogAdmin SET ctlname = (select Inserted.po_number FROM Inserted) WHERE ctlID IN (select 'PO_'+ Inserted.id FROM Inserted)
END
GO
ALTER TABLE [dbo].[PO] ENABLE TRIGGER [UpdateCatalogAdmin_After_UpdatePO]
GO
/****** Object:  Trigger [dbo].[DeleteCatalogAdmin_After_DeletePO_Thanh]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DeleteCatalogAdmin_After_DeletePO_Thanh] ON [dbo].[PO_Thanh] AFTER DELETE AS 
BEGIN
	DELETE FROM dbo.CatalogAdmin WHERE ctlID IN (SELECT 'PO_'+Deleted.id FROM Deleted)
END
GO
ALTER TABLE [dbo].[PO_Thanh] ENABLE TRIGGER [DeleteCatalogAdmin_After_DeletePO_Thanh]
GO
/****** Object:  Trigger [dbo].[InsertCatalogAdmin_After_InsertPO_Thanh]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsertCatalogAdmin_After_InsertPO_Thanh] ON [dbo].[PO_Thanh] AFTER INSERT AS 
BEGIN
	INSERT INTO dbo.CatalogAdmin
(
    ctlID,
    ctlname,
	ctlparent
)
VALUES
(   (SELECT 'PO_'+Inserted.id FROM INSERTED),
	(SELECT Inserted.poName FROM INSERTED),
	(SELECT 'Contract_'+Inserted.idContract FROM INSERTED))
END
GO
ALTER TABLE [dbo].[PO_Thanh] ENABLE TRIGGER [InsertCatalogAdmin_After_InsertPO_Thanh]
GO
/****** Object:  Trigger [dbo].[UpdateCatalogAdmin_After_UpdatePO_Thanh]    Script Date: 10/22/2021 9:15:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateCatalogAdmin_After_UpdatePO_Thanh] ON [dbo].[PO_Thanh] AFTER UPDATE AS 
BEGIN
	UPDATE dbo.CatalogAdmin SET ctlID=(select 'PO_'+Inserted.id FROM Inserted), ctlname = (select Inserted.poName FROM Inserted) WHERE ctlID IN (select 'PO_'+ Deleted.id FROM Deleted)
END
SELECT * FROM dbo.CatalogAdmin
GO
ALTER TABLE [dbo].[PO_Thanh] ENABLE TRIGGER [UpdateCatalogAdmin_After_UpdatePO_Thanh]
GO
USE [master]
GO
ALTER DATABASE [OpmDB] SET  READ_WRITE 
GO
