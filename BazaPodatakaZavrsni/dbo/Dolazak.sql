CREATE TABLE [dbo].[Dolazak] (
    [DolazakId]  INT NOT NULL,
    [DogadjajID] INT NOT NULL,
    [KorisnikID] INT NOT NULL,
    [Dolazi]     INT NOT NULL,
    CONSTRAINT [PK_Dolazak] PRIMARY KEY CLUSTERED ([DolazakId] ASC),
    CONSTRAINT [FK_Dolazak_Dogadjaj] FOREIGN KEY ([DogadjajID]) REFERENCES [dbo].[Dogadjaj] ([DogadjajID]),
    CONSTRAINT [FK_Dolazak_Korisnik] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnik] ([KorisnikID])
);


