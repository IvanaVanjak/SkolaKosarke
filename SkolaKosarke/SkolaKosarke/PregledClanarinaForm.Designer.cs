namespace SkolaKosarke
{
    partial class PregledClanarinaForm
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
            this.comboBoxClanarina = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Igrac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clanarina";
            // 
            // comboBoxClanarina
            // 
            this.comboBoxClanarina.FormattingEnabled = true;
            this.comboBoxClanarina.Location = new System.Drawing.Point(145, 44);
            this.comboBoxClanarina.Name = "comboBoxClanarina";
            this.comboBoxClanarina.Size = new System.Drawing.Size(246, 24);
            this.comboBoxClanarina.TabIndex = 1;
            this.comboBoxClanarina.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClanarina_Changed);
            this.comboBoxClanarina.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxClanarina_Format);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OIB,
            this.Igrac,
            this.BrojTelefona});
            this.listView1.Location = new System.Drawing.Point(4, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 287);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // OIB
            // 
            this.OIB.Text = "OIB";
            this.OIB.Width = 81;
            // 
            // Igrac
            // 
            this.Igrac.Text = "Igrač";
            this.Igrac.Width = 180;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona";
            this.BrojTelefona.Width = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Igrači koji nisu platili članarinu za odabrani mjesec";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(145, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(240, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PregledClanarinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxClanarina);
            this.Controls.Add(this.label1);
            this.Name = "PregledClanarinaForm";
            this.Text = "Pregled članarina";
            this.Load += new System.EventHandler(this.PregledClanarina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClanarina;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Igrac;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader OIB;
    }
}