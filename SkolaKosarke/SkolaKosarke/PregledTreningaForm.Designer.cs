namespace SkolaKosarke
{
    partial class PregledTreningaForm
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
            this.treeViewTreninzi = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewTreninzi
            // 
            this.treeViewTreninzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTreninzi.Location = new System.Drawing.Point(0, 0);
            this.treeViewTreninzi.Name = "treeViewTreninzi";
            this.treeViewTreninzi.Size = new System.Drawing.Size(592, 464);
            this.treeViewTreninzi.TabIndex = 0;
            // 
            // PregledTreningaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 464);
            this.Controls.Add(this.treeViewTreninzi);
            this.Name = "PregledTreningaForm";
            this.Text = "Pregled treninga";
            this.Load += new System.EventHandler(this.PregledTreninga_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewTreninzi;
    }
}