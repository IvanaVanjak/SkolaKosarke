namespace SkolaKosarke
{
    partial class DodavanjeClanarineForm
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
            this.numericUpDownMjesec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGodina = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIznos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMjesec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mjesec";
            // 
            // numericUpDownMjesec
            // 
            this.numericUpDownMjesec.Location = new System.Drawing.Point(179, 22);
            this.numericUpDownMjesec.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMjesec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMjesec.Name = "numericUpDownMjesec";
            this.numericUpDownMjesec.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMjesec.TabIndex = 1;
            this.numericUpDownMjesec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godina";
            // 
            // numericUpDownGodina
            // 
            this.numericUpDownGodina.Location = new System.Drawing.Point(179, 75);
            this.numericUpDownGodina.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownGodina.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownGodina.Name = "numericUpDownGodina";
            this.numericUpDownGodina.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownGodina.TabIndex = 3;
            this.numericUpDownGodina.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // numericUpDownIznos
            // 
            this.numericUpDownIznos.Location = new System.Drawing.Point(179, 132);
            this.numericUpDownIznos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIznos.Name = "numericUpDownIznos";
            this.numericUpDownIznos.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIznos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iznos članarine";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(145, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(248, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DodavanjeClanarineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownIznos);
            this.Controls.Add(this.numericUpDownGodina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMjesec);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeClanarineForm";
            this.Text = "Dodavanje članarine";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMjesec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMjesec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGodina;
        private System.Windows.Forms.NumericUpDown numericUpDownIznos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}