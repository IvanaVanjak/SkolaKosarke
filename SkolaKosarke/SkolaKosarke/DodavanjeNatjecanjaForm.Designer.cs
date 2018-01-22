namespace SkolaKosarke
{
    partial class DodavanjeNatjecanjaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGodiste = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.labelRang = new System.Windows.Forms.Label();
            this.numericUpDownRang = new System.Windows.Forms.NumericUpDown();
            this.labelBrojKlubova = new System.Windows.Forms.Label();
            this.numericUpDownBrojKlubova = new System.Windows.Forms.NumericUpDown();
            this.labelBrojBodova = new System.Windows.Forms.Label();
            this.numericUpDownBrojBodova = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojKlubova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojBodova)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(133, 32);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(259, 22);
            this.textBoxNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godište";
            // 
            // numericUpDownGodiste
            // 
            this.numericUpDownGodiste.Location = new System.Drawing.Point(133, 93);
            this.numericUpDownGodiste.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownGodiste.Minimum = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            this.numericUpDownGodiste.Name = "numericUpDownGodiste";
            this.numericUpDownGodiste.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownGodiste.TabIndex = 3;
            this.numericUpDownGodiste.Value = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrsta";
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(133, 152);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(259, 24);
            this.comboBoxVrsta.TabIndex = 5;
            this.comboBoxVrsta.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVrsta_Changed);
            // 
            // labelRang
            // 
            this.labelRang.AutoSize = true;
            this.labelRang.Location = new System.Drawing.Point(13, 210);
            this.labelRang.Name = "labelRang";
            this.labelRang.Size = new System.Drawing.Size(42, 17);
            this.labelRang.TabIndex = 6;
            this.labelRang.Text = "Rang";
            this.labelRang.Visible = false;
            // 
            // numericUpDownRang
            // 
            this.numericUpDownRang.Location = new System.Drawing.Point(133, 210);
            this.numericUpDownRang.Name = "numericUpDownRang";
            this.numericUpDownRang.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownRang.TabIndex = 7;
            this.numericUpDownRang.Visible = false;
            // 
            // labelBrojKlubova
            // 
            this.labelBrojKlubova.AutoSize = true;
            this.labelBrojKlubova.Location = new System.Drawing.Point(13, 262);
            this.labelBrojKlubova.Name = "labelBrojKlubova";
            this.labelBrojKlubova.Size = new System.Drawing.Size(86, 17);
            this.labelBrojKlubova.TabIndex = 8;
            this.labelBrojKlubova.Text = "Broj klubova";
            this.labelBrojKlubova.Visible = false;
            // 
            // numericUpDownBrojKlubova
            // 
            this.numericUpDownBrojKlubova.Location = new System.Drawing.Point(133, 257);
            this.numericUpDownBrojKlubova.Name = "numericUpDownBrojKlubova";
            this.numericUpDownBrojKlubova.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownBrojKlubova.TabIndex = 9;
            this.numericUpDownBrojKlubova.Visible = false;
            // 
            // labelBrojBodova
            // 
            this.labelBrojBodova.AutoSize = true;
            this.labelBrojBodova.Location = new System.Drawing.Point(13, 314);
            this.labelBrojBodova.Name = "labelBrojBodova";
            this.labelBrojBodova.Size = new System.Drawing.Size(84, 17);
            this.labelBrojBodova.TabIndex = 10;
            this.labelBrojBodova.Text = "Broj bodova";
            this.labelBrojBodova.Visible = false;
            // 
            // numericUpDownBrojBodova
            // 
            this.numericUpDownBrojBodova.Location = new System.Drawing.Point(133, 309);
            this.numericUpDownBrojBodova.Name = "numericUpDownBrojBodova";
            this.numericUpDownBrojBodova.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownBrojBodova.TabIndex = 11;
            this.numericUpDownBrojBodova.Visible = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(133, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(316, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DodavanjeNatjecanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownBrojBodova);
            this.Controls.Add(this.labelBrojBodova);
            this.Controls.Add(this.numericUpDownBrojKlubova);
            this.Controls.Add(this.labelBrojKlubova);
            this.Controls.Add(this.numericUpDownRang);
            this.Controls.Add(this.labelRang);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownGodiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeNatjecanjaForm";
            this.Text = "Dodavanje natjecanja";
            this.Load += new System.EventHandler(this.DodavanjeNatjecanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojKlubova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojBodova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGodiste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.Label labelRang;
        private System.Windows.Forms.NumericUpDown numericUpDownRang;
        private System.Windows.Forms.Label labelBrojKlubova;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojKlubova;
        private System.Windows.Forms.Label labelBrojBodova;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojBodova;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}