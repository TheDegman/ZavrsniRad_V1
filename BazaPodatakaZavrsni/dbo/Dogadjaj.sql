CREATE TABLE [dbo].[Dogadjaj] (
    [DogadjajID]              INT          NOT NULL,
    [DogadjajTipID]           INT          NOT NULL,
    [VlasnikVoditeljID]       INT          NOT NULL,
    [SlikaNaziv]              VARCHAR (50) NOT NULL,
    [DatumVrijemeOdrzavanja]  DATETIME     NOT NULL,
    [ProcijenjenoTrajanjeMin] INT          NOT NULL,
    [Adresa]                  VARCHAR (50) NOT NULL,
    [Otkazan]                 INT          NOT NULL,
    CONSTRAINT [PK_Dogadjaj] PRIMARY KEY CLUSTERED ([DogadjajID] ASC),
    CONSTRAINT [FK_Dogadjaj_DogadjajTip] FOREIGN KEY ([DogadjajTipID]) REFERENCES [dbo].[DogadjajTip] ([DogadjajTipID]),
    CONSTRAINT [FK_Dogadjaj_Korisnik] FOREIGN KEY ([VlasnikVoditeljID]) REFERENCES [dbo].[Korisnik] ([KorisnikID])
);

