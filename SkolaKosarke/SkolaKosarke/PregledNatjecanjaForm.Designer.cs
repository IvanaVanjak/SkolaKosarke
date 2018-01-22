namespace SkolaKosarke
{
    partial class PregledNatjecanjaForm
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
            this.listViewNatjecanje = new System.Windows.Forms.ListView();
            this.IdNat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Godiste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUtakmica = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProtivnickiKlub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostignutiKosevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimljeniKosevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewStatistike = new System.Windows.Forms.ListView();
            this.Igrac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kosevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skokovi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Asistencie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Osobne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewLige = new System.Windows.Forms.ListView();
            this.IdP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazivP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GodisteP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojKlubova = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojBodova = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewTurniri = new System.Windows.Forms.ListView();
            this.IdT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazivT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GodisteT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RangT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojKlubovaT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNatjecanje
            // 
            this.listViewNatjecanje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdNat,
            this.Naziv,
            this.Godiste});
            this.listViewNatjecanje.Location = new System.Drawing.Point(15, 31);
            this.listViewNatjecanje.Name = "listViewNatjecanje";
            this.listViewNatjecanje.Size = new System.Drawing.Size(622, 216);
            this.listViewNatjecanje.TabIndex = 0;
            this.listViewNatjecanje.UseCompatibleStateImageBehavior = false;
            this.listViewNatjecanje.View = System.Windows.Forms.View.Details;
            this.listViewNatjecanje.Click += new System.EventHandler(this.Natjecanje_Click);
            // 
            // IdNat
            // 
            this.IdNat.Text = "Id";
            this.IdNat.Width = 31;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 179;
            // 
            // Godiste
            // 
            this.Godiste.Text = "Godište";
            // 
            // listViewUtakmica
            // 
            this.listViewUtakmica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Datum,
            this.ProtivnickiKlub,
            this.PostignutiKosevi,
            this.PrimljeniKosevi});
            this.listViewUtakmica.Location = new System.Drawing.Point(656, 31);
            this.listViewUtakmica.Name = "listViewUtakmica";
            this.listViewUtakmica.Size = new System.Drawing.Size(845, 340);
            this.listViewUtakmica.TabIndex = 1;
            this.listViewUtakmica.UseCompatibleStateImageBehavior = false;
            this.listViewUtakmica.View = System.Windows.Forms.View.Details;
            this.listViewUtakmica.Click += new System.EventHandler(this.PregledNatjecanja_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 63;
            // 
            // ProtivnickiKlub
            // 
            this.ProtivnickiKlub.Text = "Protivnički klub";
            this.ProtivnickiKlub.Width = 115;
            // 
            // PostignutiKosevi
            // 
            this.PostignutiKosevi.Text = "Postignuti koševi";
            this.PostignutiKosevi.Width = 115;
            // 
            // PrimljeniKosevi
            // 
            this.PrimljeniKosevi.Text = "Primljeni koševi";
            this.PrimljeniKosevi.Width = 111;
            // 
            // listViewStatistike
            // 
            this.listViewStatistike.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Igrac,
            this.Kosevi,
            this.Skokovi,
            this.Asistencie,
            this.Osobne});
            this.listViewStatistike.Location = new System.Drawing.Point(656, 394);
            this.listViewStatistike.Name = "listViewStatistike";
            this.listViewStatistike.Size = new System.Drawing.Size(845, 347);
            this.listViewStatistike.TabIndex = 2;
            this.listViewStatistike.UseCompatibleStateImageBehavior = false;
            this.listViewStatistike.View = System.Windows.Forms.View.Details;
            // 
            // Igrac
            // 
            this.Igrac.Text = "Igrač";
            this.Igrac.Width = 176;
            // 
            // Kosevi
            // 
            this.Kosevi.Text = "Koševi";
            this.Kosevi.Width = 84;
            // 
            // Skokovi
            // 
            this.Skokovi.Text = "Skokovi";
            this.Skokovi.Width = 92;
            // 
            // Asistencie
            // 
            this.Asistencie.Text = "Asistencije";
            this.Asistencie.Width = 81;
            // 
            // Osobne
            // 
            this.Osobne.Text = "Osobne pogreške";
            this.Osobne.Width = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Utakmice na odabranom natjecanju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Statistike igrača na odabranoj utakmici";
            // 
            // listViewLige
            // 
            this.listViewLige.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdP,
            this.NazivP,
            this.GodisteP,
            this.Rang,
            this.BrojKlubova,
            this.BrojBodova});
            this.listViewLige.Location = new System.Drawing.Point(15, 278);
            this.listViewLige.Name = "listViewLige";
            this.listViewLige.Size = new System.Drawing.Size(622, 221);
            this.listViewLige.TabIndex = 6;
            this.listViewLige.UseCompatibleStateImageBehavior = false;
            this.listViewLige.View = System.Windows.Forms.View.Details;
            this.listViewLige.Click += new System.EventHandler(this.PregledLiga_Click);
            // 
            // IdP
            // 
            this.IdP.Text = "Id";
            this.IdP.Width = 32;
            // 
            // NazivP
            // 
            this.NazivP.Text = "Naziv";
            this.NazivP.Width = 129;
            // 
            // GodisteP
            // 
            this.GodisteP.Text = "Godište";
            this.GodisteP.Width = 72;
            // 
            // Rang
            // 
            this.Rang.Text = "Rang";
            this.Rang.Width = 50;
            // 
            // BrojKlubova
            // 
            this.BrojKlubova.Text = "Broj klubova";
            this.BrojKlubova.Width = 97;
            // 
            // BrojBodova
            // 
            this.BrojBodova.Text = "Broj bodova";
            this.BrojBodova.Width = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turniri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prijateljske utakmice";
            // 
            // listViewTurniri
            // 
            this.listViewTurniri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdT,
            this.NazivT,
            this.GodisteT,
            this.RangT,
            this.BrojKlubovaT});
            this.listViewTurniri.Location = new System.Drawing.Point(15, 531);
            this.listViewTurniri.Name = "listViewTurniri";
            this.listViewTurniri.Size = new System.Drawing.Size(622, 210);
            this.listViewTurniri.TabIndex = 10;
            this.listViewTurniri.UseCompatibleStateImageBehavior = false;
            this.listViewTurniri.View = System.Windows.Forms.View.Details;
            this.listViewTurniri.Click += new System.EventHandler(this.PregledTurnira_Click);
            // 
            // IdT
            // 
            this.IdT.Text = "Id";
            // 
            // NazivT
            // 
            this.NazivT.Text = "Naziv";
            this.NazivT.Width = 141;
            // 
            // GodisteT
            // 
            this.GodisteT.Text = "Godište";
            this.GodisteT.Width = 85;
            // 
            // RangT
            // 
            this.RangT.Text = "Rang";
            this.RangT.Width = 86;
            // 
            // BrojKlubovaT
            // 
            this.BrojKlubovaT.Text = "Broj klubova";
            this.BrojKlubovaT.Width = 122;
            // 
            // PregledNatjecanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 753);
            this.Controls.Add(this.listViewTurniri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewLige);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStatistike);
            this.Controls.Add(this.listViewUtakmica);
            this.Controls.Add(this.listViewNatjecanje);
            this.Name = "PregledNatjecanjaForm";
            this.Text = "Pregled natjecanja";
            this.Load += new System.EventHandler(this.PregledNatjecanja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNatjecanje;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Godiste;
        private System.Windows.Forms.ListView listViewUtakmica;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader ProtivnickiKlub;
        private System.Windows.Forms.ColumnHeader PostignutiKosevi;
        private System.Windows.Forms.ColumnHeader PrimljeniKosevi;
        private System.Windows.Forms.ListView listViewStatistike;
        private System.Windows.Forms.ColumnHeader Igrac;
        private System.Windows.Forms.ColumnHeader Kosevi;
        private System.Windows.Forms.ColumnHeader Skokovi;
        private System.Windows.Forms.ColumnHeader Asistencie;
        private System.Windows.Forms.ColumnHeader Osobne;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader IdNat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewLige;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader IdP;
        private System.Windows.Forms.ColumnHeader NazivP;
        private System.Windows.Forms.ColumnHeader GodisteP;
        private System.Windows.Forms.ColumnHeader Rang;
        private System.Windows.Forms.ColumnHeader BrojKlubova;
        private System.Windows.Forms.ColumnHeader BrojBodova;
        private System.Windows.Forms.ListView listViewTurniri;
        private System.Windows.Forms.ColumnHeader IdT;
        private System.Windows.Forms.ColumnHeader NazivT;
        private System.Windows.Forms.ColumnHeader GodisteT;
        private System.Windows.Forms.ColumnHeader RangT;
        private System.Windows.Forms.ColumnHeader BrojKlubovaT;

    }
}