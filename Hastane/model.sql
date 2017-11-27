CREATE TABLE [dbo].[HastaGecmisi] (
    [GecmisID] INT           IDENTITY (1, 1) NOT NULL,
    [HastaID]  INT           NOT NULL,
    [Tarih]    DATETIME      NOT NULL,
    [Aciklama] VARCHAR (MAX) NULL,
    [Silindi]  BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[HastaHizmetHareketler] (
    [HareketID] INT           IDENTITY (1, 1) NOT NULL,
    [Tarih]     DATETIME      NOT NULL,
    [KabulID]   INT           NOT NULL,
    [TahlilID]  INT           NOT NULL,
    [HizmetID]  INT           NOT NULL,
    [Tutar]     MONEY         NOT NULL,
    [Aciklama]  VARCHAR (MAX) NULL,
    [Silindi]   BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[HastaKabul] (
    [KabulID]     INT      IDENTITY (1, 1) NOT NULL,
    [GelisTarihi] DATETIME NOT NULL,
    [HastaID]     INT      NOT NULL,
    [PersonelID]  INT      NOT NULL,
    [KlinikID]    INT      NOT NULL,
    [SikayetID]   INT      NOT NULL,
    [CikisTarihi] DATETIME NULL
);

GO
CREATE TABLE [dbo].[Hastalar] (
    [HastaID]     INT           IDENTITY (1, 1) NOT NULL,
    [Ad]          VARCHAR (50)  NOT NULL,
    [Soyad]       VARCHAR (50)  NOT NULL,
    [TCKimlikNo]  VARCHAR (11)  NOT NULL,
    [Adres]       VARCHAR (MAX) NULL,
    [EvTel]       VARCHAR (11)  NULL,
    [CepTel]      VARCHAR (11)  NULL,
    [KanGrubu]    VARCHAR (20)  NULL,
    [DogumTarihi] DATETIME      NOT NULL,
    [Cinsiyet]    VARCHAR (11)  NOT NULL,
    [KurumID]     INT           NULL,
    [KayitTarihi] DATETIME      NOT NULL,
    [il]          VARCHAR (50)  NULL,
    [Ilce]        VARCHAR (50)  NULL,
    [Silindi]     BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[HastaSikayetleri] (
    [SikayetID] INT           IDENTITY (1, 1) NOT NULL,
    [HastaID]   INT           NOT NULL,
    [KabulID]   INT           NOT NULL,
    [Tarih]     DATETIME      NOT NULL,
    [Aciklama]  VARCHAR (MAX) NOT NULL
);

GO
CREATE TABLE [dbo].[Hizmetler] (
    [HizmetID]  INT           IDENTITY (1, 1) NOT NULL,
    [HizmetAdi] VARCHAR (50)  NOT NULL,
    [KlinikID]  INT           NOT NULL,
    [Ucret]     MONEY         NOT NULL,
    [Aciklama]  VARCHAR (MAX) NOT NULL,
    [Silindi]   BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[Klinikler] (
    [KlinikID] INT           IDENTITY (1, 1) NOT NULL,
    [KlinikAd] VARCHAR (100) NOT NULL,
    [Aciklama] VARCHAR (MAX) NULL,
    [Silindi]  BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[Kurumlar] (
    [KurumID] INT           IDENTITY (1, 1) NOT NULL,
    [KurumAd] VARCHAR (MAX) NOT NULL,
    [Iskonto] INT           NULL,
    [Silindi] BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[Odemeler] (
    [OdemeID]   INT           IDENTITY (1, 1) NOT NULL,
    [Tarih]     DATETIME      NOT NULL,
    [KabulID]   INT           NOT NULL,
    [OdemeTuru] INT           NOT NULL,
    [Toplam]    MONEY         NOT NULL,
    [Indirim]   MONEY         NOT NULL,
    [Aciklama]  VARCHAR (MAX) NULL,
    [Silindi]   BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[Personeller] (
    [PersonelID]   INT           IDENTITY (1, 1) NOT NULL,
    [SicilNo]      INT           NOT NULL,
    [UnvanID]      INT           NOT NULL,
    [KlinikID]     INT           NOT NULL,
    [Ad]           VARCHAR (50)  NOT NULL,
    [Soyad]        VARCHAR (50)  NOT NULL,
    [Adres]        VARCHAR (MAX) NOT NULL,
    [EvTel]        VARCHAR (11)  NULL,
    [CepTel]       VARCHAR (11)  NOT NULL,
    [DogumTarihi]  DATETIME      NOT NULL,
    [KullaniciAdi] VARCHAR (50)  NOT NULL,
    [Sifre]        VARCHAR (20)  NOT NULL,
    [Siilindi]     BIT           NOT NULL
);

GO
CREATE TABLE [dbo].[Randevular] (
    [RandevuID]  INT          IDENTITY (1, 1) NOT NULL,
    [Tarih]      DATETIME     NOT NULL,
    [Saat]       VARCHAR (50) NOT NULL,
    [PersonelID] INT          NOT NULL,
    [HastaID]    INT          NOT NULL,
    [Geldimi]    BIT          NULL
);

GO
CREATE TABLE [dbo].[Receteler] (
    [ReceteID]   INT          IDENTITY (1, 1) NOT NULL,
    [Tarih]      DATETIME     NOT NULL,
    [KabulID]    INT          NOT NULL,
    [KurumID]    INT          NOT NULL,
    [PersonelID] INT          NOT NULL,
    [HastaID]    INT          NOT NULL,
    [IlacAd]     VARCHAR (50) NULL,
    [Silindi]    BIT          NOT NULL
);

GO
CREATE TABLE [dbo].[SistemYoneticileri] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [Ad]           VARCHAR (50) NOT NULL,
    [Soyad]        VARCHAR (50) NOT NULL,
    [KullaniciAdi] VARCHAR (50) NOT NULL,
    [Sifre]        VARCHAR (50) NOT NULL
);

GO
CREATE TABLE [dbo].[Tahliller] (
    [TahlilID] INT           IDENTITY (1, 1) NOT NULL,
    [Tarih]    DATETIME      NOT NULL,
    [KabulID]  INT           NOT NULL,
    [Aciklama] VARCHAR (MAX) NOT NULL,
    [Silindi]  BIT           NOT NULL,
    [Sonuc]    VARCHAR (MAX) NULL
);

GO
CREATE TABLE [dbo].[Teshisler] (
    [TeshisID]   INT           IDENTITY (1, 1) NOT NULL,
    [Tarih]      DATETIME      NOT NULL,
    [PersonelID] INT           NOT NULL,
    [KabulID]    INT           NOT NULL,
    [Teshis]     VARCHAR (MAX) NOT NULL
);

GO
CREATE TABLE [dbo].[Unvanlar] (
    [UnvanID]       INT          IDENTITY (1, 1) NOT NULL,
    [PersonelUnvan] VARCHAR (50) NOT NULL
);

GO
ALTER TABLE [dbo].[HastaGecmisi]
    ADD CONSTRAINT [FK_HastaGecmisi_Hastalar] FOREIGN KEY ([HastaID]) REFERENCES [dbo].[Hastalar] ([HastaID]);

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [FK_HastaHizmetHareketler_HastaKabul] FOREIGN KEY ([KabulID]) REFERENCES [dbo].[HastaKabul] ([KabulID]);

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [FK_HastaHizmetHareketler_Hizmetler] FOREIGN KEY ([HizmetID]) REFERENCES [dbo].[Hizmetler] ([HizmetID]);

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [FK_HastaHizmetHareketler_Tahliller] FOREIGN KEY ([TahlilID]) REFERENCES [dbo].[Tahliller] ([TahlilID]);

GO
ALTER TABLE [dbo].[HastaKabul]
    ADD CONSTRAINT [FK_HastaKabul_Hastalar] FOREIGN KEY ([HastaID]) REFERENCES [dbo].[Hastalar] ([HastaID]);

GO
ALTER TABLE [dbo].[HastaKabul]
    ADD CONSTRAINT [FK_HastaKabul_HastaSikayetleri] FOREIGN KEY ([SikayetID]) REFERENCES [dbo].[HastaSikayetleri] ([SikayetID]);

GO
ALTER TABLE [dbo].[HastaKabul]
    ADD CONSTRAINT [FK_HastaKabul_Klinikler] FOREIGN KEY ([KlinikID]) REFERENCES [dbo].[Klinikler] ([KlinikID]);

GO
ALTER TABLE [dbo].[HastaKabul]
    ADD CONSTRAINT [FK_HastaKabul_Personeller] FOREIGN KEY ([PersonelID]) REFERENCES [dbo].[Personeller] ([PersonelID]);

GO
ALTER TABLE [dbo].[Hastalar]
    ADD CONSTRAINT [FK_Hastalar_Kurumlar] FOREIGN KEY ([KurumID]) REFERENCES [dbo].[Kurumlar] ([KurumID]);

GO
ALTER TABLE [dbo].[HastaSikayetleri]
    ADD CONSTRAINT [FK_HastaSikayetleri_HastaKabul] FOREIGN KEY ([KabulID]) REFERENCES [dbo].[HastaKabul] ([KabulID]);

GO
ALTER TABLE [dbo].[HastaSikayetleri]
    ADD CONSTRAINT [FK_HastaSikayetleri_Hastalar] FOREIGN KEY ([HastaID]) REFERENCES [dbo].[Hastalar] ([HastaID]);

GO
ALTER TABLE [dbo].[Hizmetler]
    ADD CONSTRAINT [FK_Hizmetler_Klinikler] FOREIGN KEY ([KlinikID]) REFERENCES [dbo].[Klinikler] ([KlinikID]);

GO
ALTER TABLE [dbo].[Odemeler]
    ADD CONSTRAINT [FK_Odemeler_HastaKabul] FOREIGN KEY ([KabulID]) REFERENCES [dbo].[HastaKabul] ([KabulID]);

GO
ALTER TABLE [dbo].[Personeller]
    ADD CONSTRAINT [FK_Personeller_Klinikler] FOREIGN KEY ([KlinikID]) REFERENCES [dbo].[Klinikler] ([KlinikID]);

GO
ALTER TABLE [dbo].[Personeller]
    ADD CONSTRAINT [FK_Personeller_Unvanlar] FOREIGN KEY ([UnvanID]) REFERENCES [dbo].[Unvanlar] ([UnvanID]);

GO
ALTER TABLE [dbo].[Randevular]
    ADD CONSTRAINT [FK_Randevular_Hastalar] FOREIGN KEY ([HastaID]) REFERENCES [dbo].[Hastalar] ([HastaID]);

GO
ALTER TABLE [dbo].[Randevular]
    ADD CONSTRAINT [FK_Randevular_Personeller] FOREIGN KEY ([PersonelID]) REFERENCES [dbo].[Personeller] ([PersonelID]);

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [FK_Receteler_HastaKabul] FOREIGN KEY ([KabulID]) REFERENCES [dbo].[HastaKabul] ([KabulID]);

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [FK_Receteler_Hastalar] FOREIGN KEY ([HastaID]) REFERENCES [dbo].[Hastalar] ([HastaID]);

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [FK_Receteler_Kurumlar] FOREIGN KEY ([KurumID]) REFERENCES [dbo].[Kurumlar] ([KurumID]);

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [FK_Receteler_Personeller] FOREIGN KEY ([PersonelID]) REFERENCES [dbo].[Personeller] ([PersonelID]);

GO
ALTER TABLE [dbo].[Tahliller]
    ADD CONSTRAINT [FK_Tahliller_HastaKabul] FOREIGN KEY ([KabulID]) REFERENCES [dbo].[HastaKabul] ([KabulID]);

GO
ALTER TABLE [dbo].[Teshisler]
    ADD CONSTRAINT [FK_Teshisler_HastaKabul] FOREIGN KEY ([KabulID]) REFERENCES [dbo].[HastaKabul] ([KabulID]);

GO
ALTER TABLE [dbo].[Teshisler]
    ADD CONSTRAINT [FK_Teshisler_Personeller] FOREIGN KEY ([PersonelID]) REFERENCES [dbo].[Personeller] ([PersonelID]);

GO
ALTER TABLE [dbo].[HastaGecmisi]
    ADD CONSTRAINT [DF_HastaGecmisi_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[HastaGecmisi]
    ADD CONSTRAINT [DF_HastaGecmisi_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [DF_HastaHizmetHareketler_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [DF_HastaHizmetHareketler_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [DF_HastaHizmetHareketler_Tutar] DEFAULT ((0)) FOR [Tutar];

GO
ALTER TABLE [dbo].[HastaKabul]
    ADD CONSTRAINT [DF_HastaKabul_GelisTarihi] DEFAULT (getdate()) FOR [GelisTarihi];

GO
ALTER TABLE [dbo].[Hastalar]
    ADD CONSTRAINT [DF_Hastalar_KayitTarihi] DEFAULT (getdate()) FOR [KayitTarihi];

GO
ALTER TABLE [dbo].[Hastalar]
    ADD CONSTRAINT [DF_Hastalar_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[HastaSikayetleri]
    ADD CONSTRAINT [DF_HastaSikayetleri_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[Hizmetler]
    ADD CONSTRAINT [DF_Hizmetler_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[Hizmetler]
    ADD CONSTRAINT [DF_Hizmetler_Ucret] DEFAULT ((0)) FOR [Ucret];

GO
ALTER TABLE [dbo].[Klinikler]
    ADD CONSTRAINT [DF_Klinikler_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[Kurumlar]
    ADD CONSTRAINT [DF_Kurumlar_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[Odemeler]
    ADD CONSTRAINT [DF_Odemeler_Indirim] DEFAULT ((0)) FOR [Indirim];

GO
ALTER TABLE [dbo].[Odemeler]
    ADD CONSTRAINT [DF_Odemeler_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[Odemeler]
    ADD CONSTRAINT [DF_Odemeler_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[Personeller]
    ADD CONSTRAINT [DF_Personeller_Siilindi] DEFAULT ((0)) FOR [Siilindi];

GO
ALTER TABLE [dbo].[Randevular]
    ADD CONSTRAINT [DF_Randevular_Geldimi] DEFAULT ((0)) FOR [Geldimi];

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [DF_Receteler_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [DF_Receteler_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[Tahliller]
    ADD CONSTRAINT [DF_Tahliller_Silindi] DEFAULT ((0)) FOR [Silindi];

GO
ALTER TABLE [dbo].[Tahliller]
    ADD CONSTRAINT [DF_Tahliller_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[Teshisler]
    ADD CONSTRAINT [DF_Teshisler_Tarih] DEFAULT (getdate()) FOR [Tarih];

GO
ALTER TABLE [dbo].[HastaGecmisi]
    ADD CONSTRAINT [PK_HastaGecmisi] PRIMARY KEY CLUSTERED ([GecmisID] ASC);

GO
ALTER TABLE [dbo].[HastaHizmetHareketler]
    ADD CONSTRAINT [PK_HastaHizmetHareketler] PRIMARY KEY CLUSTERED ([HareketID] ASC);

GO
ALTER TABLE [dbo].[HastaKabul]
    ADD CONSTRAINT [PK_HastaKabul] PRIMARY KEY CLUSTERED ([KabulID] ASC);

GO
ALTER TABLE [dbo].[Hastalar]
    ADD CONSTRAINT [PK_Hastalar] PRIMARY KEY CLUSTERED ([HastaID] ASC);

GO
ALTER TABLE [dbo].[HastaSikayetleri]
    ADD CONSTRAINT [PK_HastaSikayetleri] PRIMARY KEY CLUSTERED ([SikayetID] ASC);

GO
ALTER TABLE [dbo].[Hizmetler]
    ADD CONSTRAINT [PK_Hizmetler] PRIMARY KEY CLUSTERED ([HizmetID] ASC);

GO
ALTER TABLE [dbo].[Klinikler]
    ADD CONSTRAINT [PK_Klinikler] PRIMARY KEY CLUSTERED ([KlinikID] ASC);

GO
ALTER TABLE [dbo].[Kurumlar]
    ADD CONSTRAINT [PK_Kurumlar] PRIMARY KEY CLUSTERED ([KurumID] ASC);

GO
ALTER TABLE [dbo].[Odemeler]
    ADD CONSTRAINT [PK_Odemeler] PRIMARY KEY CLUSTERED ([OdemeID] ASC);

GO
ALTER TABLE [dbo].[Personeller]
    ADD CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED ([PersonelID] ASC);

GO
ALTER TABLE [dbo].[Randevular]
    ADD CONSTRAINT [PK_Randevular] PRIMARY KEY CLUSTERED ([RandevuID] ASC);

GO
ALTER TABLE [dbo].[Receteler]
    ADD CONSTRAINT [PK_Receteler] PRIMARY KEY CLUSTERED ([ReceteID] ASC);

GO
ALTER TABLE [dbo].[Tahliller]
    ADD CONSTRAINT [PK_Tahliller] PRIMARY KEY CLUSTERED ([TahlilID] ASC);

GO
ALTER TABLE [dbo].[Teshisler]
    ADD CONSTRAINT [PK_Teshisler] PRIMARY KEY CLUSTERED ([TeshisID] ASC);

GO
ALTER TABLE [dbo].[Unvanlar]
    ADD CONSTRAINT [PK_Unvanlar] PRIMARY KEY CLUSTERED ([UnvanID] ASC);

GO
ALTER TABLE [dbo].[SistemYoneticileri]
    ADD CONSTRAINT [PK_Yoneticiler] PRIMARY KEY CLUSTERED ([ID] ASC);

GO
