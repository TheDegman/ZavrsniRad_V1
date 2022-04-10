CREATE TABLE [dbo].[Napomena] (
    [NapomenaID] INT          NOT NULL,
    [Tekst]      VARCHAR (50) NOT NULL,
    [KorisnikID] INT          NOT NULL,
    [Zasticena]  INT          NOT NULL,
    [DogadjajID] INT          NOT NULL,
    CONSTRAINT [PK_Napomena] PRIMARY KEY CLUSTERED ([NapomenaID] ASC),
    CONSTRAINT [FK_Napomena_Korisnik] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnik] ([KorisnikID]),
    CONSTRAINT [FK_Napomena_Dogadjaj] FOREIGN KEY ([DogadjajID]) REFERENCES [dbo].[Dogadjaj] ([DogadjajID])
);

