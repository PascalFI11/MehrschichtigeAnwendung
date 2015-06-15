using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace KundenDataAccess
{
    public partial class DataTransfer : Component
    {
        private List<Kunde> alKunden = new List<Kunde>();

        public DataTransfer()
        {
            InitializeComponent();
        }

        public DataTransfer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        public List<Kunde> GetAlleKunden()
        {
            oleDbKunden.Open();
            OleDbDataReader drKunde = cmd_Kunden_Anzeigen.ExecuteReader();
            while (drKunde.Read())
            {
                Kunde k = new Kunde();
                k.MKundenId = drKunde.GetString(0);
                k.MName = drKunde.GetString(1);
                k.MVorname = drKunde.GetString(2);
                k.MgebDatum = drKunde.GetString(3);
                alKunden.Add(k);
            }
            drKunde.Close();
            return alKunden;
        }

        internal void InsertKunde(Kunde kunde)
        {
            this.oleDbKunden.Open();
            this.cmd_Kunden_Insert.Parameters["KundenID"].Value = kunde.MKundenId;
            this.cmd_Kunden_Insert.Parameters["Name"].Value = kunde.MName;
            this.cmd_Kunden_Insert.Parameters["VName"].Value = kunde.MVorname;
            this.cmd_Kunden_Insert.Parameters["GebDat"].Value = kunde.MgebDatum;
            try
            {
                cmd_Kunden_Insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
