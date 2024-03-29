﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad_V1.ModelBaze
{
    class Korisnik
    {
        public int KorisnikID { get; set; }
        public int UlogaID { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string ImeIspis
        {
            get { return $"{Ime}"; }
        }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public int Telefon { get; set; }
        public int BrojOsiguranja { get; set; }
        public string FotografijaNaziv { get; set; }
        public string Lozinka { get; set; }
        public string Info
        {
            get { return $"{KorisnikID}{UlogaID}{Email}{Ime}{Prezime}{DatumRodjenja}{Adresa}{Telefon}{BrojOsiguranja}{FotografijaNaziv}{Lozinka}"; }
        }
        


    }
}
