CREATE TABLE [dbo].[Korisnik] (
    [KorisnikID]       INT          NOT NULL,
    [UlogaID]          INT          NOT NULL,
    [Email]            VARCHAR (50) NOT NULL,
    [Ime]              VARCHAR (50) NOT NULL,
    [Prezime]          VARCHAR (50) NOT NULL,
    [DatumRodjenja]    DATETIME     NOT NULL,
    [Adresa]           VARCHAR (50) NOT NULL,
    [Telefon]          INT          NOT NULL,
    [BrojOsiguranja]   INT          NOT NULL,
    [FotografijaNaziv] VARCHAR (50) NOT NULL,
    [Lozinka]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED ([KorisnikID] ASC),
    CONSTRAINT [FK_Korisnik_Uloga] FOREIGN KEY ([UlogaID]) REFERENCES [dbo].[Uloga] ([UlogaID])
);

