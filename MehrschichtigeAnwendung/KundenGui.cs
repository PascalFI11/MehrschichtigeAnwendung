using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using KundenDataAccess;

namespace MehrschichtigeAnwendung
{
    public partial class KundenGui : Form
    {

        private List<Kunde> alKunden = new List<Kunde>();

        public KundenGui()
        {
            InitializeComponent();
        }

        private void btnKundenAnzeigen_Click(object sender, EventArgs e)
        {
            KundenDataAccess.DataTransfer dtr = new KundenDataAccess.DataTransfer();
            alKunden = dtr.GetAlleKunden();
            comboBox1.Items.Clear();
            comboBox1.DataSource = alKunden;
            txtGebDatum.DataBindings.Add("Text", alKunden, "mgebDatum");
            txtKundenId.DataBindings.Add("Text", alKunden, "mKundenId");
            txtName.DataBindings.Add("Text", alKunden, "mName");
            txtVorname.DataBindings.Add("Text", alKunden, "mVorname");
        }

        private void btnKundenAufnehmen_Click(object sender, EventArgs e)
        {
            Kunde ku = new Kunde();
            ku.MKundenId = txtKundenId.Text;
            ku.MName = txtName.Text;
            ku.MVorname = txtVorname.Text;
            ku.MgebDatum = txtGebDatum.Text;
            ku.insert();
        }
    }
}
