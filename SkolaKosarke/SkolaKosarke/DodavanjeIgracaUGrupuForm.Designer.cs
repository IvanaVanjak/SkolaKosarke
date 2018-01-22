namespace SkolaKosarke
{
    partial class DodavanjeIgracaUGrupuForm
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
            this.comboBoxIgrac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGrupa = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxIgrac
            // 
            this.comboBoxIgrac.FormattingEnabled = true;
            this.comboBoxIgrac.Location = new System.Drawing.Point(192, 25);
            this.comboBoxIgrac.Name = "comboBoxIgrac";
            this.comboBoxIgrac.Size = new System.Drawing.Size(217, 24);
            this.comboBoxIgrac.TabIndex = 0;
            this.comboBoxIgrac.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.IgracComboBox_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Igrac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupa";
            // 
            // comboBoxGrupa
            // 
            this.comboBoxGrupa.FormattingEnabled = true;
            this.comboBoxGrupa.Location = new System.Drawing.Point(192, 84);
            this.comboBoxGrupa.Name = "comboBoxGrupa";
            this.comboBoxGrupa.Size = new System.Drawing.Size(217, 24);
            this.comboBoxGrupa.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(192, 157);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 37);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(333, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DodavanjeIgracaUGrupuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.comboBoxGrupa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIgrac);
            this.Name = "DodavanjeIgracaUGrupuForm";
            this.Text = "Dodavanje igraca u grupu";
            this.Load += new System.EventHandler(this.DodavanjeIgraca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIgrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGrupa;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button button2;
    }
}