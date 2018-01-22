namespace SkolaKosarke
{
    partial class PregledGrupaTreningaForm
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
            this.treeViewPregledavanjeGrupaTreninga = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewPregledavanjeGrupaTreninga
            // 
            this.treeViewPregledavanjeGrupaTreninga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPregledavanjeGrupaTreninga.Location = new System.Drawing.Point(0, 0);
            this.treeViewPregledavanjeGrupaTreninga.Name = "treeViewPregledavanjeGrupaTreninga";
            this.treeViewPregledavanjeGrupaTreninga.Size = new System.Drawing.Size(760, 350);
            this.treeViewPregledavanjeGrupaTreninga.TabIndex = 0;
            // 
            // PregledGrupaTreningaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.treeViewPregledavanjeGrupaTreninga);
            this.Name = "PregledGrupaTreningaForm";
            this.Text = "Pregledavanje grupa treninga";
            this.Load += new System.EventHandler(this.PregledGrupa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPregledavanjeGrupaTreninga;

    }
}