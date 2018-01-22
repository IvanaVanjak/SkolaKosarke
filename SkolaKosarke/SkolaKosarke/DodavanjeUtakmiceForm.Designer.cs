namespace SkolaKosarke
{
    partial class DodavanjeUtakmiceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProtivnickiKlub = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownBrojPostgnutih = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownBrojPrimljenih = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxIgraci = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojPostgnutih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojPrimljenih)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Natjecanje";
            // 
            // comboBoxNatjecanje
            // 
            this.comboBoxNatjecanje.FormattingEnabled = true;
            this.comboBoxNatjecanje.Location = new System.Drawing.Point(206, 29);
            this.comboBoxNatjecanje.Name = "comboBoxNatjecanje";
            this.comboBoxNatjecanje.Size = new System.Drawing.Size(204, 24);
            this.comboBoxNatjecanje.TabIndex = 1;
            this.comboBoxNatjecanje.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNatjecanje_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(206, 65);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(204, 22);
            this.dateTimePickerDatum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Protivniči klub";
            // 
            // comboBoxProtivnickiKlub
            // 
            this.comboBoxProtivnickiKlub.FormattingEnabled = true;
            this.comboBoxProtivnickiKlub.Location = new System.Drawing.Point(206, 97);
            this.comboBoxProtivnickiKlub.Name = "comboBoxProtivnickiKlub";
            this.comboBoxProtivnickiKlub.Size = new System.Drawing.Size(204, 24);
            this.comboBoxProtivnickiKlub.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj postignutih koševa";
            // 
            // numericUpDownBrojPostgnutih
            // 
            this.numericUpDownBrojPostgnutih.Location = new System.Drawing.Point(206, 129);
            this.numericUpDownBrojPostgnutih.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownBrojPostgnutih.Name = "numericUpDownBrojPostgnutih";
            this.numericUpDownBrojPostgnutih.Size = new System.Drawing.Size(204, 22);
            this.numericUpDownBrojPostgnutih.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Broj primljenih koševa";
            // 
            // numericUpDownBrojPrimljenih
            // 
            this.numericUpDownBrojPrimljenih.Location = new System.Drawing.Point(206, 165);
            this.numericUpDownBrojPrimljenih.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownBrojPrimljenih.Name = "numericUpDownBrojPrimljenih";
            this.numericUpDownBrojPrimljenih.Size = new System.Drawing.Size(204, 22);
            this.numericUpDownBrojPrimljenih.TabIndex = 9;
            // 
            // checkedListBoxIgraci
            // 
            this.checkedListBoxIgraci.FormattingEnabled = true;
            this.checkedListBoxIgraci.Location = new System.Drawing.Point(206, 198);
            this.checkedListBoxIgraci.Name = "checkedListBoxIgraci";
            this.checkedListBoxIgraci.Size = new System.Drawing.Size(204, 395);
            this.checkedListBoxIgraci.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(206, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(335, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Igrači na utakmici";
            // 
            // DodavanjeUtakmiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 678);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxIgraci);
            this.Controls.Add(this.numericUpDownBrojPrimljenih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownBrojPostgnutih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProtivnickiKlub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNatjecanje);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeUtakmiceForm";
            this.Text = "Dodavanje utakmice";
            this.Load += new System.EventHandler(this.DodavanjeUtakmice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojPostgnutih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojPrimljenih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNatjecanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProtivnickiKlub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojPostgnutih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojPrimljenih;
        private System.Windows.Forms.CheckedListBox checkedListBoxIgraci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}