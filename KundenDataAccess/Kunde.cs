using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundenDataAccess
{
    public class Kunde
    {

        private string mgebDatum;

        public string MgebDatum
        {
            get { return mgebDatum; }
            set { mgebDatum = value; }
        }
        private string mKundenId;

        public string MKundenId
        {
            get { return mKundenId; }
            set { mKundenId = value; }
        }
        private string mName;

        public string MName
        {
            get { return mName; }
            set { mName = value; }
        }
        private string mVorname;

        public string MVorname
        {
            get { return mVorname; }
            set { mVorname = value; }
        }

        private string mStrasse;

        public string MStrasse
        {
            get { return mStrasse; }
            set { mStrasse = value; }
        }
        private string mOrt;

        public string MOrt
        {
            get { return mOrt; }
            set { mOrt = value; }
        }
        private string mPlz;

        public string MPlz
        {
            get { return mPlz; }
            set { mPlz = value; }
        }

        public void insert()
        {
            DataTransfer dt = new DataTransfer();
            dt.InsertKunde(this);
        }

        public Kunde()
        {

        }

        public override string ToString()
        {
            String a = "";
            a = mKundenId + " " + mName;
            return a;
        }
    }
}
