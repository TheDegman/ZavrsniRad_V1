using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad_V1.ModelBaze
{
    class Korisnik
    {
        public int KorisnikID { get; set; }
        public string UlogaID { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public int Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public int Telefon { get; set; }
        public int BrojOsiguranja { get; set; }
        public string FotografijaNaziv { get; set; }
        public string Lozinka { get; set; }


    }
}
