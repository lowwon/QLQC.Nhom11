USE [qlQcao]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [nchar](10) NOT NULL,
	[NgayKy] [date] NULL,
	[MaNV] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](60) NULL,
	[GT] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khach_Hang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai_QC]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_QC](
	[MaLoai] [nchar](10) NOT NULL,
	[HinhThuc] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_Loai_QC] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](60) NULL,
	[MaNhom] [nchar](10) NULL,
	[NgSinh] [date] NULL,
	[NgVaoLam] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[GT] [nvarchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhom_NV]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom_NV](
	[MaNhom] [nchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
	[MaNT] [nchar](10) NULL,
 CONSTRAINT [PK_Nhom_NV] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QC_LQC]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QC_LQC](
	[MaQC] [nchar](10) NOT NULL,
	[MaLoai] [nchar](10) NOT NULL,
 CONSTRAINT [PK_QC_LQC] PRIMARY KEY CLUSTERED 
(
	[MaQC] ASC,
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quang_Cao]    Script Date: 1/30/2022 5:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quang_Cao](
	[MaQC] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NULL,
	[MaNhom] [nchar](10) NULL,
	[NgBD] [date] NULL,
	[NgKT] [date] NULL,
	[YeuCau] [nvarchar](500) NULL,
	[SoTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Quang_Cao] PRIMARY KEY CLUSTERED 
(
	[MaQC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1504      ', CAST(N'2015-04-30' AS Date), N'NV23      ', N'KH08      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1507      ', CAST(N'2015-07-25' AS Date), N'NV04      ', N'KH10      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1511      ', CAST(N'2015-11-15' AS Date), N'NV29      ', N'KH03      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1602      ', CAST(N'2016-02-08' AS Date), N'NV11      ', N'KH01      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1606      ', CAST(N'2016-06-18' AS Date), N'NV05      ', N'KH16      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1609      ', CAST(N'2016-09-22' AS Date), N'NV30      ', N'KH07      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1612      ', CAST(N'2016-12-19' AS Date), N'NV08      ', N'KH20      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1703      ', CAST(N'2017-03-06' AS Date), N'NV24      ', N'KH04      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1708      ', CAST(N'2017-08-20' AS Date), N'NV29      ', N'KH05      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1801      ', CAST(N'2018-01-12' AS Date), N'NV26      ', N'KH18      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1805      ', CAST(N'2018-05-09' AS Date), N'NV23      ', N'KH08      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1807      ', CAST(N'2018-07-01' AS Date), N'NV16      ', N'KH06      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1810      ', CAST(N'2018-10-16' AS Date), N'NV28      ', N'KH17      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1812      ', CAST(N'2018-12-05' AS Date), N'NV20      ', N'KH13      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1904      ', CAST(N'2019-04-18' AS Date), N'NV09      ', N'KH04      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1909      ', CAST(N'2019-09-03' AS Date), N'NV06      ', N'KH15      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'1911      ', CAST(N'2019-11-26' AS Date), N'NV30      ', N'KH02      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'2001      ', CAST(N'2020-01-19' AS Date), N'NV17      ', N'KH11      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'2007      ', CAST(N'2020-07-04' AS Date), N'NV21      ', N'KH19      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'2010      ', CAST(N'2020-10-09' AS Date), N'NV10      ', N'KH12      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'2103      ', CAST(N'2021-03-29' AS Date), N'NV01      ', N'KH09      ')
INSERT [dbo].[HopDong] ([MaHD], [NgayKy], [MaNV], [MaKH]) VALUES (N'2108      ', CAST(N'2021-08-07' AS Date), N'NV14      ', N'KH14      ')
GO
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH01      ', N'Hà Thoại Anh', N'Nam', N'thoaianh135@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH02      ', N'Nguyễn Thiện Hiếu', N'Nam', N'thienhieu89@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH03      ', N'Trần Thu Hoài', N'Nữ', N'hoaithu@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH04      ', N'Lê Duy Khánh', N'Nam', N'khanhle55@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH05      ', N'Nguyễn Mai Linh', N'Nữ', N'linhmai67@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH06      ', N'Trần Công Minh', N'Nam', N'cminhtran@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH07      ', N'Đoàn Minh Quân', N'Nam', N'quanquan32@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH08      ', N'Vũ Văn Quý', N'Nam', N'vanquyvu@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH09      ', N'Trần Minh Tâm', N'Nam', N'tamminh123@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH10      ', N'Vũ Ngọc Thịnh', N'Nam', N'vngocthinh@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH11      ', N'Hoàng Kim Thủy', N'Nữ', N'thuykim20@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH12      ', N'Trương Công Vinh', N'Nam', N'congvinhhh@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH13      ', N'Lê Quốc Vinh', N'Nam', N'vinhquooc@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH14      ', N'Nguyễn Ngọc Yến', N'Nữ', N'yenngoc44@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH15      ', N'Phạm Mai Vy', N'Nữ', N'maivyy123@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH16      ', N'Trương Công Vinh', N'Nam', N'congvinhhh@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH17      ', N'Lê Quốc Vinh', N'Nam', N'vinhquooc@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH18      ', N'Nguyễn Ngọc Yến', N'Nữ', N'yenngoc44@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH19      ', N'Phạm Mai Vy', N'Nữ', N'maivyy123@gmail.com')
INSERT [dbo].[Khach_Hang] ([MaKH], [TenKH], [GT], [Email]) VALUES (N'KH20      ', N'Vũ Thị Yến Vy', N'Nữ', N'vyvy20@gmail.com')
GO
INSERT [dbo].[Loai_QC] ([MaLoai], [HinhThuc], [MoTa]) VALUES (N'L01       ', N'Quảng cáo facebook', N'Dịch Vụ Quảng cáo Facebook là hình thức quảng cáo trả phí để hiển thị hình ảnh quảng cáo trên trang mạng xã hội Facebook, hình ảnh quảng cáo được hiển thị ở các vị trí quy định của Facebook.')
INSERT [dbo].[Loai_QC] ([MaLoai], [HinhThuc], [MoTa]) VALUES (N'L02       ', N'Quảng cáo Instagram', N'Các bài đăng quảng cáo sử dụng hình ảnh, video ngắn, đường dẫn liên kết đến trang web của công ty, các cửa hàng được đăng tải trên newsfeed (bảng tin), stories của Instagram nhằm mục đích bán hàng, thúc đẩy thương hiệu,')
INSERT [dbo].[Loai_QC] ([MaLoai], [HinhThuc], [MoTa]) VALUES (N'L03       ', N'Quảng cáo Google Adwords', N'Google Ads là chương trình quảng cáo trực tuyến của Google. Thông qua Google Ads, bạn có thể tạo quảng cáo trực tuyến để tiếp cận chính xác những người quan tâm đến các sản phẩm và dịch vụ mà bạn cung cấp.')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV01      ', N'Nguyễn Thị An', N'N01       ', CAST(N'1996-06-05' AS Date), CAST(N'2013-12-01' AS Date), N'anna@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV02      ', N'Nguyễn Kim Anh', N'N03       ', CAST(N'1993-08-15' AS Date), CAST(N'2018-08-26' AS Date), N'nguyenanh@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV03      ', N'Nguyễn Xuân Bình', N'N02       ', CAST(N'1989-08-10' AS Date), CAST(N'2012-03-22' AS Date), N'binhnguyen@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV04      ', N'Trần Minh Chiến', N'N11       ', CAST(N'1989-10-20' AS Date), CAST(N'2011-04-23' AS Date), N'minhchien@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV05      ', N'Cao Văn Cường', N'N09       ', CAST(N'1995-10-20' AS Date), CAST(N'2015-09-18' AS Date), N'vancuongg@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV06      ', N'Hồ Thị Diệu', N'N04       ', CAST(N'1987-12-29' AS Date), CAST(N'2017-07-30' AS Date), N'thidieu@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV07      ', N'Nguyễn Phương Dung', N'N08       ', CAST(N'1995-06-23' AS Date), CAST(N'2015-04-22' AS Date), N'dungnguyen389@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV08      ', N'Võ Thị Dung', N'N07       ', CAST(N'1991-09-02' AS Date), CAST(N'2016-05-20' AS Date), N'dungvo875@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV09      ', N'Trần Đức Duy', N'N02       ', CAST(N'1986-12-01' AS Date), CAST(N'2011-09-04' AS Date), N'duy001@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV10      ', N'Huỳnh Thu Duyên', N'N06       ', CAST(N'1999-04-22' AS Date), CAST(N'2017-05-10' AS Date), N'duyenthu@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV11      ', N'Trần Xuân Đạt', N'N05       ', CAST(N'1990-09-14' AS Date), CAST(N'2021-06-07' AS Date), N'dat666@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV12      ', N'Nguyễn Trường Giang', N'N10       ', CAST(N'1991-02-17' AS Date), CAST(N'2018-09-01' AS Date), N'truonggiang@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV13      ', N'Vũ Hà', N'N02       ', CAST(N'1995-06-27' AS Date), CAST(N'2021-10-09' AS Date), N'vuha1314@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV14      ', N'Đỗ Duy Hải', N'N01       ', CAST(N'1993-11-02' AS Date), CAST(N'2017-03-04' AS Date), N'haiduy@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV15      ', N'Nguyễn thị Hạnh', N'N10       ', CAST(N'1990-02-14' AS Date), CAST(N'2015-12-09' AS Date), N'hanhthi@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV16      ', N'Phạm Ngọc Hân', N'N11       ', CAST(N'1994-07-25' AS Date), CAST(N'2015-05-19' AS Date), N'ngochan@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV17      ', N'Nguyễn Kim Hồng', N'N08       ', CAST(N'1997-03-28' AS Date), CAST(N'2021-04-29' AS Date), N'kimhong@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV18      ', N'Trương Gia Chí', N'N09       ', CAST(N'1989-06-28' AS Date), CAST(N'2019-02-20' AS Date), N'giachi12@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV19      ', N'Lê Phương Mạnh', N'N06       ', CAST(N'1985-03-29' AS Date), CAST(N'2020-01-01' AS Date), N'phuongmanh@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV20      ', N'Đỗ Duy Nam', N'N03       ', CAST(N'1990-09-20' AS Date), CAST(N'2017-10-09' AS Date), N'duynam78@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV21      ', N'Lưu Thị Quỳnh', N'N06       ', CAST(N'1992-10-04' AS Date), CAST(N'2015-03-27' AS Date), N'quynh2001@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV22      ', N'Phạm Như Quỳnh', N'N09       ', CAST(N'1994-07-19' AS Date), CAST(N'2019-04-16' AS Date), N'nhuquynh@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV23      ', N'Đặng Thụy', N'N08       ', CAST(N'1987-05-30' AS Date), CAST(N'2015-01-20' AS Date), N'thuy567@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV24      ', N'Trương Thị Thùy Trang', N'N07       ', CAST(N'1990-09-23' AS Date), CAST(N'2016-01-01' AS Date), N'trang333@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV25      ', N'Trần Kiều Trang', N'N05       ', CAST(N'1997-04-15' AS Date), CAST(N'2019-12-25' AS Date), N'trangthi@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV26      ', N'Cao Quốc Tuấn', N'N10       ', CAST(N'1995-02-22' AS Date), CAST(N'2017-06-28' AS Date), N'tuannn@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV27      ', N'Trần Chí Việt', N'N03       ', CAST(N'1997-11-28' AS Date), CAST(N'2020-09-18' AS Date), N'vietchi@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV28      ', N'Lê Vương Vũ', N'N06       ', CAST(N'1990-12-15' AS Date), CAST(N'2010-03-23' AS Date), N'vuongvu@gmail.com', N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV29      ', N'Lê Yến Vy', N'N01       ', CAST(N'1995-10-17' AS Date), CAST(N'2022-01-01' AS Date), N'yenvy435@gmail.com', N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNhom], [NgSinh], [NgVaoLam], [Email], [GT]) VALUES (N'NV30      ', N'Trần Yến', N'N04       ', CAST(N'1996-06-20' AS Date), CAST(N'2021-02-09' AS Date), N'yentran@gmail.com', N'Nữ')
GO
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N01       ', N'Sun', N'NV29      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N02       ', N'Moon', N'NV10      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N03       ', N'Earth', N'NV08      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N04       ', N'Blue', N'NV01      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N05       ', N'Green', N'NV05      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N06       ', N'Violiet', N'NV09      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N07       ', N'Happy', N'NV03      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N08       ', N'Mafia', N'NV11      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N09       ', N'Ravens  ', N'NV12      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N10       ', N'Gators ', N'NV20      ')
INSERT [dbo].[Nhom_NV] ([MaNhom], [TenNhom], [MaNT]) VALUES (N'N11       ', N'Elephants ', N'NV25      ')
GO
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'A         ', N'L01       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'A         ', N'L02       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'B         ', N'L01       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'B         ', N'L02       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'C         ', N'L02       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'C         ', N'L03       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'D         ', N'L01       ')
INSERT [dbo].[QC_LQC] ([MaQC], [MaLoai]) VALUES (N'D         ', N'L03       ')
GO
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'A         ', N'KH01      ', N'N01       ', CAST(N'2017-01-02' AS Date), CAST(N'2017-02-02' AS Date), N'"- Tăng độ tiếp cận
- Tăng tương tác
- Bài viết được thay đổi
- Chọn khu vực, độ tuổi, sở thích, chức danh"', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'B         ', N'KH02      ', N'N11       ', CAST(N'2018-02-02' AS Date), CAST(N'2019-02-15' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'C         ', N'KH03      ', N'N03       ', CAST(N'2019-02-20' AS Date), CAST(N'2019-04-10' AS Date), N'Mẫu quảng cáo, Tiện ích mở rộng, Khung thời gian, Áp dụng hệ thống chống click ảo', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'D         ', N'KH04      ', N'N02       ', CAST(N'2020-07-02' AS Date), CAST(N'2021-02-15' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'DE        ', N'KH12      ', N'N03       ', CAST(N'2021-02-20' AS Date), CAST(N'2021-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'F         ', N'KH05      ', N'N10       ', CAST(N'2019-02-20' AS Date), CAST(N'2019-04-10' AS Date), N'"- Tăng độ tiếp cận
- Tăng tương tác
- Bài viết được thay đổi
- Chọn khu vực, độ tuổi, sở thích, chức danh"', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'FE        ', N'KH16      ', N'N05       ', CAST(N'2017-02-20' AS Date), CAST(N'2017-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'G         ', N'KH03      ', N'N05       ', CAST(N'2020-01-02' AS Date), CAST(N'2020-02-15' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'H         ', N'KH06      ', N'N06       ', CAST(N'2019-02-20' AS Date), CAST(N'2019-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'IM        ', N'KH07      ', N'N07       ', CAST(N'2017-01-05' AS Date), CAST(N'2017-10-11' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'IT        ', N'KH09      ', N'N11       ', CAST(N'2021-01-02' AS Date), CAST(N'2021-03-03' AS Date), N'"- Tăng độ tiếp cận
- Tăng tương tác
- Bài viết được thay đổi
- Chọn khu vực, độ tuổi, sở thích, chức danh"', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'LL        ', N'KH15      ', N'N09       ', CAST(N'2018-02-03' AS Date), CAST(N'2018-02-14' AS Date), N'Mẫu quảng cáo, Tiện ích mở rộng, Khung thời gian, Áp dụng hệ thống chống click ảo', CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'NEU       ', N'KH11      ', N'N06       ', CAST(N'2021-01-05' AS Date), CAST(N'2021-06-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'NX        ', N'KH08      ', N'N07       ', CAST(N'2020-02-20' AS Date), CAST(N'2020-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'OU        ', N'KH20      ', N'N05       ', CAST(N'2020-01-02' AS Date), CAST(N'2020-06-01' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'PO        ', N'KH18      ', N'N06       ', CAST(N'2019-02-20' AS Date), CAST(N'2020-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'RE        ', N'KH10      ', N'N04       ', CAST(N'2020-02-20' AS Date), CAST(N'2020-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'TY        ', N'KH11      ', N'N01       ', CAST(N'2019-02-20' AS Date), CAST(N'2019-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'WE        ', N'KH14      ', N'N02       ', CAST(N'2018-02-20' AS Date), CAST(N'2018-04-10' AS Date), N'Viết hoặc đổi bài đưng,  Viết bài, up hình ảnh và chỉnh đối tượng quảng cáo sao cho hiệu quả nhất.', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[Quang_Cao] ([MaQC], [MaKH], [MaNhom], [NgBD], [NgKT], [YeuCau], [SoTien]) VALUES (N'XR        ', N'KH17      ', N'N08       ', CAST(N'2021-01-10' AS Date), CAST(N'2021-11-11' AS Date), N'Mẫu quảng cáo, Tiện ích mở rộng, Khung thời gian, Áp dụng hệ thống chống click ảo', CAST(1000000 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_Khach_Hang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khach_Hang] ([MaKH])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_Khach_Hang]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_NhanVien1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Nhom_NV] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom_NV] ([MaNhom])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Nhom_NV]
GO
ALTER TABLE [dbo].[Nhom_NV]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_NV_NhanVien] FOREIGN KEY([MaNT])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Nhom_NV] CHECK CONSTRAINT [FK_Nhom_NV_NhanVien]
GO
ALTER TABLE [dbo].[QC_LQC]  WITH CHECK ADD  CONSTRAINT [FK_QC_LQC_Loai_QC] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai_QC] ([MaLoai])
GO
ALTER TABLE [dbo].[QC_LQC] CHECK CONSTRAINT [FK_QC_LQC_Loai_QC]
GO
ALTER TABLE [dbo].[QC_LQC]  WITH CHECK ADD  CONSTRAINT [FK_QC_LQC_Quang_Cao] FOREIGN KEY([MaQC])
REFERENCES [dbo].[Quang_Cao] ([MaQC])
GO
ALTER TABLE [dbo].[QC_LQC] CHECK CONSTRAINT [FK_QC_LQC_Quang_Cao]
GO
ALTER TABLE [dbo].[Quang_Cao]  WITH CHECK ADD  CONSTRAINT [FK_Quang_Cao_Khach_Hang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khach_Hang] ([MaKH])
GO
ALTER TABLE [dbo].[Quang_Cao] CHECK CONSTRAINT [FK_Quang_Cao_Khach_Hang]
GO
ALTER TABLE [dbo].[Quang_Cao]  WITH CHECK ADD  CONSTRAINT [FK_Quang_Cao_Nhom_NV] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom_NV] ([MaNhom])
GO
ALTER TABLE [dbo].[Quang_Cao] CHECK CONSTRAINT [FK_Quang_Cao_Nhom_NV]
GO
USE [master]
GO
ALTER DATABASE [qlQcao] SET  READ_WRITE 
GO
