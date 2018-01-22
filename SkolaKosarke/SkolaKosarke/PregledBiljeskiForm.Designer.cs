namespace SkolaKosarke
{
    partial class PregledBiljeskiForm
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
            this.comboBoxIgrac = new System.Windows.Forms.ComboBox();
            this.listViewBiljeska = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igrač";
            // 
            // comboBoxIgrac
            // 
            this.comboBoxIgrac.FormattingEnabled = true;
            this.comboBoxIgrac.Location = new System.Drawing.Point(183, 39);
            this.comboBoxIgrac.Name = "comboBoxIgrac";
            this.comboBoxIgrac.Size = new System.Drawing.Size(175, 24);
            this.comboBoxIgrac.TabIndex = 1;
            this.comboBoxIgrac.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIgrac_Changed);
            this.comboBoxIgrac.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBoxIgrac_Format);
            // 
            // listViewBiljeska
            // 
            this.listViewBiljeska.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewBiljeska.Location = new System.Drawing.Point(1, 91);
            this.listViewBiljeska.Name = "listViewBiljeska";
            this.listViewBiljeska.Size = new System.Drawing.Size(559, 345);
            this.listViewBiljeska.TabIndex = 2;
            this.listViewBiljeska.UseCompatibleStateImageBehavior = false;
            this.listViewBiljeska.View = System.Windows.Forms.View.Details;
            this.listViewBiljeska.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bilješka";
            this.columnHeader2.Width = 401;
            // 
            // PregledBiljeskiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 436);
            this.Controls.Add(this.listViewBiljeska);
            this.Controls.Add(this.comboBoxIgrac);
            this.Controls.Add(this.label1);
            this.Name = "PregledBiljeskiForm";
            this.Text = "Pregled bilješki";
            this.Load += new System.EventHandler(this.PregledBiljeski_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIgrac;
        private System.Windows.Forms.ListView listViewBiljeska;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}