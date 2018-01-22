namespace SkolaKosarke
{
    partial class DodavanjeStatistikeForm
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
            this.comboBoxNatjecanje = new System.Windows.Forms.ComboBox();
            this.comboBoxUtakmica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIgrac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownKosevi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSkokovi = new System.Windows.Forms.NumericUpDown();
            this.Asistencije = new System.Windows.Forms.Label();
            this.numericUpDownAsistencije = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownOsobne = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKosevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkokovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsistencije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOsobne)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Natjecanje";
            // 
            // comboBoxNatjecanje
            // 
            this.comboBoxNatjecanje.FormattingEnabled = true;
            this.comboBoxNatjecanje.Location = new System.Drawing.Point(191, 24);
            this.comboBoxNatjecanje.Name = "comboBoxNatjecanje";
            this.comboBoxNatjecanje.Size = new System.Drawing.Size(188, 24);
            this.comboBoxNatjecanje.TabIndex = 1;
            this.comboBoxNatjecanje.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNatjecanje_Changed);
            // 
            // comboBoxUtakmica
            // 
            this.comboBoxUtakmica.FormattingEnabled = true;
            this.comboBoxUtakmica.Location = new System.Drawing.Point(191, 79);
            this.comboBoxUtakmica.Name = "comboBoxUtakmica";
            this.comboBoxUtakmica.Size = new System.Drawing.Size(188, 24);
            this.comboBoxUtakmica.TabIndex = 3;
            this.comboBoxUtakmica.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUtakmica_Changed);
            this.comboBoxUtakmica.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxUtakmica_Format);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Igrač";
            // 
            // comboBoxIgrac
            // 
            this.comboBoxIgrac.FormattingEnabled = true;
            this.comboBoxIgrac.Location = new System.Drawing.Point(191, 130);
            this.comboBoxIgrac.Name = "comboBoxIgrac";
            this.comboBoxIgrac.Size = new System.Drawing.Size(188, 24);
            this.comboBoxIgrac.TabIndex = 5;
            this.comboBoxIgrac.SelectedIndexChanged += new System.EventHandler(this.IgracComboBox_Changed);
            this.comboBoxIgrac.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxIgrac_Format);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koševi";
            // 
            // numericUpDownKosevi
            // 
            this.numericUpDownKosevi.Location = new System.Drawing.Point(191, 191);
            this.numericUpDownKosevi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownKosevi.Name = "numericUpDownKosevi";
            this.numericUpDownKosevi.Size = new System.Drawing.Size(188, 22);
            this.numericUpDownKosevi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skokovi";
            // 
            // numericUpDownSkokovi
            // 
            this.numericUpDownSkokovi.Location = new System.Drawing.Point(191, 241);
            this.numericUpDownSkokovi.Name = "numericUpDownSkokovi";
            this.numericUpDownSkokovi.Size = new System.Drawing.Size(188, 22);
            this.numericUpDownSkokovi.TabIndex = 9;
            // 
            // Asistencije
            // 
            this.Asistencije.AutoSize = true;
            this.Asistencije.Location = new System.Drawing.Point(13, 291);
            this.Asistencije.Name = "Asistencije";
            this.Asistencije.Size = new System.Drawing.Size(75, 17);
            this.Asistencije.TabIndex = 10;
            this.Asistencije.Text = "Asistencije";
            // 
            // numericUpDownAsistencije
            // 
            this.numericUpDownAsistencije.Location = new System.Drawing.Point(191, 289);
            this.numericUpDownAsistencije.Name = "numericUpDownAsistencije";
            this.numericUpDownAsistencije.Size = new System.Drawing.Size(188, 22);
            this.numericUpDownAsistencije.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Osobne pogreške";
            // 
            // numericUpDownOsobne
            // 
            this.numericUpDownOsobne.Location = new System.Drawing.Point(191, 342);
            this.numericUpDownOsobne.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownOsobne.Name = "numericUpDownOsobne";
            this.numericUpDownOsobne.Size = new System.Drawing.Size(188, 22);
            this.numericUpDownOsobne.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Utakmica";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(191, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(304, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DodavanjeStatistikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownOsobne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownAsistencije);
            this.Controls.Add(this.Asistencije);
            this.Controls.Add(this.numericUpDownSkokovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownKosevi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIgrac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUtakmica);
            this.Controls.Add(this.comboBoxNatjecanje);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeStatistikeForm";
            this.Text = "Dodavanje statistike";
            this.Load += new System.EventHandler(this.DodavanjeStatistike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKosevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkokovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsistencije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOsobne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNatjecanje;
        private System.Windows.Forms.ComboBox comboBoxUtakmica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIgrac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownKosevi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSkokovi;
        private System.Windows.Forms.Label Asistencije;
        private System.Windows.Forms.NumericUpDown numericUpDownAsistencije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownOsobne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}