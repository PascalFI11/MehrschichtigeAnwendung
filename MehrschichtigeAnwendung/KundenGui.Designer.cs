namespace MehrschichtigeAnwendung
{
    partial class KundenGui
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKundenAnzeigen = new System.Windows.Forms.Button();
            this.btnKundenAufnehmen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGebDatum = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKundenId = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKundenAnzeigen
            // 
            this.btnKundenAnzeigen.Location = new System.Drawing.Point(35, 70);
            this.btnKundenAnzeigen.Name = "btnKundenAnzeigen";
            this.btnKundenAnzeigen.Size = new System.Drawing.Size(164, 23);
            this.btnKundenAnzeigen.TabIndex = 0;
            this.btnKundenAnzeigen.Text = "Kunden anzeigen";
            this.btnKundenAnzeigen.UseVisualStyleBackColor = true;
            this.btnKundenAnzeigen.Click += new System.EventHandler(this.btnKundenAnzeigen_Click);
            // 
            // btnKundenAufnehmen
            // 
            this.btnKundenAufnehmen.Location = new System.Drawing.Point(309, 114);
            this.btnKundenAufnehmen.Name = "btnKundenAufnehmen";
            this.btnKundenAufnehmen.Size = new System.Drawing.Size(126, 23);
            this.btnKundenAufnehmen.TabIndex = 1;
            this.btnKundenAufnehmen.Text = "Kunden aufnehmen";
            this.btnKundenAufnehmen.UseVisualStyleBackColor = true;
            this.btnKundenAufnehmen.Click += new System.EventHandler(this.btnKundenAufnehmen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KundenId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Geb-Datum";
            // 
            // txtGebDatum
            // 
            this.txtGebDatum.Location = new System.Drawing.Point(99, 331);
            this.txtGebDatum.Name = "txtGebDatum";
            this.txtGebDatum.Size = new System.Drawing.Size(100, 20);
            this.txtGebDatum.TabIndex = 6;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(99, 276);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(100, 20);
            this.txtVorname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 226);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtKundenId
            // 
            this.txtKundenId.Location = new System.Drawing.Point(99, 175);
            this.txtKundenId.Name = "txtKundenId";
            this.txtKundenId.Size = new System.Drawing.Size(100, 20);
            this.txtKundenId.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // KundenGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 496);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtKundenId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtGebDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKundenAufnehmen);
            this.Controls.Add(this.btnKundenAnzeigen);
            this.Name = "KundenGui";
            this.Text = "Kundenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKundenAnzeigen;
        private System.Windows.Forms.Button btnKundenAufnehmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGebDatum;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKundenId;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

