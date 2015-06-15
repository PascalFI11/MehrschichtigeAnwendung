namespace KundenDataAccess
{
    partial class DataTransfer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.oleDbKunden = new System.Data.OleDb.OleDbConnection();
            this.cmd_Kunden_Insert = new System.Data.OleDb.OleDbCommand();
            this.cmd_Kunden_Anzeigen = new System.Data.OleDb.OleDbCommand();
            // 
            // oleDbKunden
            // 
            this.oleDbKunden.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"\\\\172.16.1.1\\Fi2013$\\HettrichPascal" +
    "\\Eigene Dateien\\Visual Studio 2013\\Projects\\MehrschichtigeAnwendung\\KundenDataAc" +
    "cess\\kunden.mdb\"";
            this.oleDbKunden.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection1_InfoMessage);
            // 
            // cmd_Kunden_Insert
            // 
            this.cmd_Kunden_Insert.CommandText = "INSERT INTO Kunden\r\n                         (KundenID, Name, VName, GebDat)\r\nVAL" +
    "UES        (?, ?, ?, ?)";
            this.cmd_Kunden_Insert.Connection = this.oleDbKunden;
            this.cmd_Kunden_Insert.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("KundenID", System.Data.OleDb.OleDbType.WChar, 50, "KundenID"),
            new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.WChar, 255, "Name"),
            new System.Data.OleDb.OleDbParameter("VName", System.Data.OleDb.OleDbType.WChar, 255, "VName"),
            new System.Data.OleDb.OleDbParameter("GebDat", System.Data.OleDb.OleDbType.WChar, 50, "GebDat")});
            // 
            // cmd_Kunden_Anzeigen
            // 
            this.cmd_Kunden_Anzeigen.CommandText = "SELECT        Kunden.*\r\nFROM            Kunden";
            this.cmd_Kunden_Anzeigen.Connection = this.oleDbKunden;

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleDbKunden;
        private System.Data.OleDb.OleDbCommand cmd_Kunden_Insert;
        private System.Data.OleDb.OleDbCommand cmd_Kunden_Anzeigen;
    }
}
