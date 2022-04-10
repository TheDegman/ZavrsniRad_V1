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


namespace ZavrsniRad_V1
{
    public partial class Form1 : Form
    {
        List<Korisnik> ljudi = new List<Korisnik>();
        public Form1()
        {
            InitializeComponent();
        }
        //private void Update1()
        //{
        //    Upisani.DataSource = ljudi;
        //    Upisani.DisplayMember = "Info";
        //}

        private void prijavaBTN_Click(object sender, EventArgs e)
        {
            PristupBazi db=new PristupBazi();
            ljudi=db.PrijavaKorisnik();
            
            //if(ljudi.Contains(new Korisnik { Email = emailTB.Text, Lozinka = lozinkaTB.Text }))
            //{
            //    emailTB.Text = null;
            //    lozinkaTB.Text = null;



            //}
            //else
            //{
            //    prijavaBTN.Text = null;
            //}

            if((ljudi.Exists(x => x.Email == emailTB.Text))||(ljudi.Exists(x => x.Lozinka == lozinkaTB.Text)))
            {
                
                VoditeljForma form2 = new VoditeljForma();
                form2.Show();

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
    }
}
