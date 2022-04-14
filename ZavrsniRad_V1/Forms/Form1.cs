using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZavrsniRad_V1.ModelBaze;
using ZavrsniRad_V1.Forms;


namespace ZavrsniRad_V1
{
    public partial class Glavna : Form
    {
        List<Korisnik> ljudi = new List<Korisnik>();
        public Glavna()
        {
            InitializeComponent();
            
        }
        private void prijavaBTN_Click_1(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            ljudi = db.PrijavaKorisnik();


            int resultEmail = ljudi.FindIndex(x => x.Email == emailTB.Text);
            int resultLozinka = ljudi.FindIndex(x => x.Lozinka == lozinkaTB.Text);



            if (resultEmail == resultLozinka)
            {
                if (ljudi[resultEmail].UlogaID == 1)
                {
                    
                    voditeljUC1.BringToFront();
                    voditeljUC1.Prijenos(resultLozinka);
                }
                else
                {
                    korisnikUC1.BringToFront();

                }

            }
            else
            {
                string message = "Krivi email ili lozinka";
                string title = "Greška";
                MessageBox.Show(message, title);
                emailTB.Text = null;
                lozinkaTB.Text = null;

            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            voditeljUC1.BringToFront();

        }

        
    }
}
