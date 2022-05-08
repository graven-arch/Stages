
namespace Gestion_Note.RAPPORTS
{
    partial class FRM_RAPPORT
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
            this.rpvnote = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvnote
            // 
            this.rpvnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvnote.Location = new System.Drawing.Point(0, 0);
            this.rpvnote.Name = "rpvnote";
            this.rpvnote.ServerReport.BearerToken = null;
            this.rpvnote.Size = new System.Drawing.Size(713, 561);
            this.rpvnote.TabIndex = 0;
            // 
            // FRM_RAPPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 561);
            this.Controls.Add(this.rpvnote);
            this.Name = "FRM_RAPPORT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport de Note";
            this.Load += new System.EventHandler(this.FRM_RAPPORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvnote;
    }
}