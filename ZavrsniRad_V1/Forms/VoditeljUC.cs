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
namespace ZavrsniRad_V1.Forms
{
    public partial class VoditeljUC : UserControl
    {
        List<Korisnik> ljudi = new List<Korisnik>();

        int ID = 0;
        public VoditeljUC()
        {
            InitializeComponent();
            PristupBazi db = new PristupBazi();
            ljudi = db.PrijavaKorisnik();
            korisnikToolStripMenuItem.Text = ljudi[ID].ImeIspis;
            dataGridView1.DataSource = ljudi;
            








        }
        public void Prijenos(int id)
        {
            id = ID;


        }
    }
}
