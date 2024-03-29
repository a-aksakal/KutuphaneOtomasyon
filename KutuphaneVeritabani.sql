USE [Wissen]
GO
/****** Object:  Table [dbo].[AlinanKitaplar]    Script Date: 7.11.2021 15:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlinanKitaplar](
	[Kitap_adi] [nvarchar](50) NULL,
	[Kitap_turu] [nvarchar](50) NULL,
	[Yazar_adi] [nvarchar](50) NULL,
	[Yazar_soyadi] [nvarchar](50) NULL,
	[Yayin_evi] [nvarchar](50) NULL,
	[Basim_yili] [int] NULL,
	[Stok_durumu] [int] NULL,
	[Kullanici] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 7.11.2021 15:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[Kitap_adi] [nvarchar](50) NULL,
	[Kitap_turu] [nvarchar](50) NULL,
	[Yazar_adi] [nvarchar](50) NULL,
	[Yazar_soyadi] [nvarchar](50) NULL,
	[Yayin_evi] [nvarchar](50) NULL,
	[Basim_yili] [int] NULL,
	[Stok_durumu] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sifreler]    Script Date: 7.11.2021 15:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sifreler](
	[Kullanici_Adi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AlinanKitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu], [Kullanici]) VALUES (N'Anna Kareinna', N'Roman', N'Tolstoy', N'Tolstoy', N'Konya Yayınevi', 2002, 2, N'Alican')
INSERT [dbo].[AlinanKitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu], [Kullanici]) VALUES (N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Aşk', N'Roman', N'Elif', N'Şafak', N'Ankara Yayınevi', 2006, 5)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Anna Kareinna', N'Roman', N'Tolstoy', N'Tolstoy', N'Konya Yayınevi', 2002, 10)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Nefes Nefese', N'Roman', N'Ayşe', N'Kulin', N'Ahmet Yayınevi', 2014, 3)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Karartma Geceleri', N'Roman', N'Rıfat', N'Ilgaz', N'DK Yayınevi', 2012, 1)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Son Ada', N'Roman', N'Zülfü', N'Livaneli', N'AT Yayınevi', 2017, 2)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Malzeme Bilimi', N'Ders Kitabı', N'Ahmet', N'Şensoy', N'Bilim Yayınevi', 2016, 2)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Kalite Yönetimi', N'Ders Kitabı', N'Fatma', N'Turgut', N'Bilim Yayınevi', 2011, 1)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Faz Diyagramları', N'Ders Kitabı', N'Mustafa', N'Kocaman', N'Nutuk Yayınevi', 2002, 3)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'C# Programlama', N'Ders Kitabı', N'Ufuk', N'Murtaza', N'Bahçeşehir Yayınevi', 2021, 5)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Televizyon Temelleri', N'Makale', N'Okancan', N'Okan', N'Tekirdağ Yayınevi', 2015, 2)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Havalar Nasıl', N'Makale', N'Murat', N'Samancı', N'GOP Yayınevi', 2019, 1)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Titanic Neden Battı', N'Makale', N'Alican', N'Aksakal', N'Zonguldak Yayınevi', 2014, 2)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Lider Nasıl Olunur', N'Kişisel Gelişim', N'Emre', N'Fırat', N'Konya Yayınevi', 2013, 3)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Sudoku', N'Eğlence', N'Ahmet', N'Nuri', N'Matematik Yayınevi', 2001, 9)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Marmara Denizi Krizi', N'Makale', N'Murat', N'Samancı', N'Bilim Yayınevi', 2020, 4)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Pandeminin Ekonomik Etkileri', N'Makale', N'Alican', N'Aksakal', N'TOBB Yayınevi', 2021, 5)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Diferansiyel Denklemler', N'Akademik', N'Barış', N'Avar', N'Ecevit Yayınevi', 2001, 4)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'Full Stack Temelleri', N'Makale', N'Tuğçe', N'Yüksel', N'Karamürsel Yayınevi', 2015, 5)
INSERT [dbo].[Kitaplar] ([Kitap_adi], [Kitap_turu], [Yazar_adi], [Yazar_soyadi], [Yayin_evi], [Basim_yili], [Stok_durumu]) VALUES (N'CEO olmanın beş yolu', N'Kişisel Gelişim', N'Okancan', N'Okan', N'Tekirdağ Yayınevi', 2020, 4)
GO
INSERT [dbo].[Sifreler] ([Kullanici_Adi], [Sifre]) VALUES (N'sa', N'1234')
GO
