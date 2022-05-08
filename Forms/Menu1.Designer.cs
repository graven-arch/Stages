
namespace Gestion_Note.Forms
{
    partial class Menu1
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDep = new System.Windows.Forms.Panel();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAfficher = new System.Windows.Forms.Panel();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCompte = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnNoteService = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.pnlMenu.Controls.Add(this.pnlDep);
            this.pnlMenu.Controls.Add(this.btnCompte);
            this.pnlMenu.Controls.Add(this.btnAccueil);
            this.pnlMenu.Controls.Add(this.btnNote);
            this.pnlMenu.Controls.Add(this.btnNoteService);
            this.pnlMenu.Controls.Add(this.btnEmploye);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 711);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlDep
            // 
            this.pnlDep.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlDep.Location = new System.Drawing.Point(0, 63);
            this.pnlDep.Name = "pnlDep";
            this.pnlDep.Size = new System.Drawing.Size(10, 77);
            this.pnlDep.TabIndex = 13;
            this.pnlDep.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDep_Paint);
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAccueil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAccueil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAccueil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAccueil.Location = new System.Drawing.Point(0, 70);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(236, 63);
            this.btnAccueil.TabIndex = 8;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = false;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(236, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(982, 18);
            this.pnlTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnReduce);
            this.panel1.Controls.Add(this.pnlAfficher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(236, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 693);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlAfficher
            // 
            this.pnlAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAfficher.BackColor = System.Drawing.Color.LightGray;
            this.pnlAfficher.Location = new System.Drawing.Point(0, 63);
            this.pnlAfficher.Name = "pnlAfficher";
            this.pnlAfficher.Size = new System.Drawing.Size(932, 600);
            this.pnlAfficher.TabIndex = 11;
            // 
            // btnReduce
            // 
            this.btnReduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduce.FlatAppearance.BorderSize = 0;
            this.btnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduce.Image = global::Gestion_Note.Properties.Resources.minus__1_;
            this.btnReduce.Location = new System.Drawing.Point(906, 1);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(32, 29);
            this.btnReduce.TabIndex = 9;
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Gestion_Note.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(944, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCompte
            // 
            this.btnCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnCompte.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCompte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompte.FlatAppearance.BorderSize = 0;
            this.btnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompte.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompte.Image = global::Gestion_Note.Properties.Resources.user;
            this.btnCompte.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCompte.Location = new System.Drawing.Point(10, 512);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(220, 72);
            this.btnCompte.TabIndex = 12;
            this.btnCompte.Text = "Compte";
            this.btnCompte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompte.UseVisualStyleBackColor = false;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNote.Image = global::Gestion_Note.Properties.Resources.edit__3_;
            this.btnNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNote.Location = new System.Drawing.Point(3, 382);
            this.btnNote.Name = "btnNote";
            this.btnNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNote.Size = new System.Drawing.Size(233, 75);
            this.btnNote.TabIndex = 11;
            this.btnNote.Text = "Demande de Note";
            this.btnNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnNoteService
            // 
            this.btnNoteService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnNoteService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNoteService.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNoteService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoteService.FlatAppearance.BorderSize = 0;
            this.btnNoteService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNoteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoteService.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNoteService.Image = global::Gestion_Note.Properties.Resources.paper;
            this.btnNoteService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoteService.Location = new System.Drawing.Point(1, 269);
            this.btnNoteService.Name = "btnNoteService";
            this.btnNoteService.Size = new System.Drawing.Size(236, 70);
            this.btnNoteService.TabIndex = 10;
            this.btnNoteService.Text = "Note de Service";
            this.btnNoteService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNoteService.UseVisualStyleBackColor = false;
            this.btnNoteService.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // btnEmploye
            // 
            this.btnEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmploye.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEmploye.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEmploye.Image = global::Gestion_Note.Properties.Resources.profile__1_;
            this.btnEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploye.Location = new System.Drawing.Point(3, 155);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(233, 71);
            this.btnEmploye.TabIndex = 9;
            this.btnEmploye.Text = "Employe";
            this.btnEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmploye.UseVisualStyleBackColor = false;
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDep;
        private System.Windows.Forms.Panel pnlAfficher;
        public System.Windows.Forms.Button btnNote;
        public System.Windows.Forms.Button btnEmploye;
        public System.Windows.Forms.Button btnNoteService;
    }
}