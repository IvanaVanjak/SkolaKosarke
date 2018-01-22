namespace SkolaKosarke
{
    partial class PregledKlubovaForm
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
            this.NazivKluba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KucniBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostanskiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drzava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPregledKlubova = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NazivKluba
            // 
            this.NazivKluba.Text = "Naziv kluba";
            this.NazivKluba.Width = 93;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona";
            this.BrojTelefona.Width = 95;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            // 
            // KucniBroj
            // 
            this.KucniBroj.Text = "Kućni broj";
            this.KucniBroj.Width = 80;
            // 
            // PostanskiBroj
            // 
            this.PostanskiBroj.Text = "Poštanski broj";
            this.PostanskiBroj.Width = 99;
            // 
            // Mjesto
            // 
            this.Mjesto.Text = "Mjesto";
            this.Mjesto.Width = 107;
            // 
            // Drzava
            // 
            this.Drzava.Text = "Država";
            this.Drzava.Width = 119;
            // 
            // listViewPregledKlubova
            // 
            this.listViewPregledKlubova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NazivKluba,
            this.BrojTelefona,
            this.Ulica,
            this.KucniBroj,
            this.PostanskiBroj,
            this.Mjesto,
            this.Drzava});
            this.listViewPregledKlubova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPregledKlubova.Location = new System.Drawing.Point(0, 0);
            this.listViewPregledKlubova.Name = "listViewPregledKlubova";
            this.listViewPregledKlubova.Size = new System.Drawing.Size(984, 387);
            this.listViewPregledKlubova.TabIndex = 0;
            this.listViewPregledKlubova.UseCompatibleStateImageBehavior = false;
            this.listViewPregledKlubova.View = System.Windows.Forms.View.Details;
            // 
            // PregledKlubovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 387);
            this.Controls.Add(this.listViewPregledKlubova);
            this.Name = "PregledKlubovaForm";
            this.Text = "Pregled klubova";
            this.Load += new System.EventHandler(this.PregledKlubovaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader NazivKluba;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader KucniBroj;
        private System.Windows.Forms.ColumnHeader PostanskiBroj;
        private System.Windows.Forms.ColumnHeader Mjesto;
        private System.Windows.Forms.ColumnHeader Drzava;
        private System.Windows.Forms.ListView listViewPregledKlubova;


    }
}