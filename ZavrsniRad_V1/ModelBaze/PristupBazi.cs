using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;



namespace ZavrsniRad_V1.ModelBaze
{
    class PristupBazi
    {
        //provjera email i lozinka od voditelja
       public List<Korisnik> PrijavaKorisnik()
        {         
            using (IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaZavrsni; User Id = dorian; Password = lozinka;"))
            {
                var a=connection.Query<Korisnik>("SELECT * FROM BazaPodatakaZavrsni.dbo.Korisnik").ToList();
                return a;
            }     
        }
    }
}
