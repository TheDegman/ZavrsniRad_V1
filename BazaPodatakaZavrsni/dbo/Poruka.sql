CREATE TABLE [dbo].[Poruka] (
    [PorukaID]              INT          NOT NULL,
    [DogadjajID]            INT          NOT NULL,
    [KorisnikID]            INT          NOT NULL,
    [Tekst]                 VARCHAR (50) NOT NULL,
    [DatumVrijemeKreiranja] DATETIME     NOT NULL,
    CONSTRAINT [PK_Poruka] PRIMARY KEY CLUSTERED ([PorukaID] ASC),
    CONSTRAINT [FK_Poruka_Dogadjaj] FOREIGN KEY ([DogadjajID]) REFERENCES [dbo].[Dogadjaj] ([DogadjajID]),
    CONSTRAINT [FK_Poruka_Korisnik] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnik] ([KorisnikID])
);

