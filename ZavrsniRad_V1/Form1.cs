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

        private void prijavaBTN_Click(object sender, EventArgs e)
        {
            PristupBazi db=new PristupBazi();
            ljudi=db.PrijavaKorisnik();
            string email=emailTB.Text;
            ljudi.Contains()
            
        }
    }
}
