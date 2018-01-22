namespace SkolaKosarke
{
    partial class PregledIgracaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPregledIgraca = new System.Windows.Forms.ListView();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumRodenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImeRoditelja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimeRoditelja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPregledIgraca
            // 
            this.listViewPregledIgraca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Prezime,
            this.Nadimak,
            this.OIB,
            this.datumRodenja,
            this.ImeRoditelja,
            this.PrezimeRoditelja,
            this.BrojTelefona});
            this.listViewPregledIgraca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPregledIgraca.Location = new System.Drawing.Point(0, 0);
            this.listViewPregledIgraca.Name = "listViewPregledIgraca";
            this.listViewPregledIgraca.Size = new System.Drawing.Size(1043, 444);
            this.listViewPregledIgraca.TabIndex = 0;
            this.listViewPregledIgraca.UseCompatibleStateImageBehavior = false;
            this.listViewPregledIgraca.View = System.Windows.Forms.View.Details;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 73;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 87;
            // 
            // Nadimak
            // 
            this.Nadimak.Text = "Nadimak";
            this.Nadimak.Width = 82;
            // 
            // OIB
            // 
            this.OIB.Text = "OIB";
            this.OIB.Width = 79;
            // 
            // datumRodenja
            // 
            this.datumRodenja.Text = "Datum rođenja";
            this.datumRodenja.Width = 106;
            // 
            // ImeRoditelja
            // 
            this.ImeRoditelja.Text = "Ime roditelja";
            this.ImeRoditelja.Width = 108;
            // 
            // PrezimeRoditelja
            // 
            this.PrezimeRoditelja.Text = "Prezime roditelja";
            this.PrezimeRoditelja.Width = 120;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona";
            this.BrojTelefona.Width = 98;
            // 
            // PregledIgracaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 444);
            this.Controls.Add(this.listViewPregledIgraca);
            this.Name = "PregledIgracaForm";
            this.Text = "Pregled igrača";
            this.Load += new System.EventHandler(this.PregledIgracaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPregledIgraca;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader OIB;
        private System.Windows.Forms.ColumnHeader ImeRoditelja;
        private System.Windows.Forms.ColumnHeader PrezimeRoditelja;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private System.Windows.Forms.ColumnHeader datumRodenja;
        private System.Windows.Forms.ColumnHeader Nadimak;
    }
}