
namespace Gestion_Note.Forms
{
    partial class FRM_EnvoiD
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFichier = new System.Windows.Forms.Label();
            this.textBoxFichier = new System.Windows.Forms.TextBox();
            this.btnchoix = new System.Windows.Forms.Button();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObjet = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDestinataire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Image = global::Gestion_Note.Properties.Resources.vcsconflicting_93497;
            this.btnQuit.Location = new System.Drawing.Point(677, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(34, 37);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.TabStop = false;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(711, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 433);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 433);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 3);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 3);
            this.panel4.TabIndex = 8;
            // 
            // lblFichier
            // 
            this.lblFichier.AutoSize = true;
            this.lblFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFichier.Location = new System.Drawing.Point(9, 125);
            this.lblFichier.Name = "lblFichier";
            this.lblFichier.Size = new System.Drawing.Size(231, 24);
            this.lblFichier.TabIndex = 9;
            this.lblFichier.Text = "Choisir le fichier à envoyer";
            // 
            // textBoxFichier
            // 
            this.textBoxFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFichier.Location = new System.Drawing.Point(263, 130);
            this.textBoxFichier.Name = "textBoxFichier";
            this.textBoxFichier.Size = new System.Drawing.Size(355, 29);
            this.textBoxFichier.TabIndex = 10;
            // 
            // btnchoix
            // 
            this.btnchoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoix.Location = new System.Drawing.Point(614, 130);
            this.btnchoix.Name = "btnchoix";
            this.btnchoix.Size = new System.Drawing.Size(43, 29);
            this.btnchoix.TabIndex = 11;
            this.btnchoix.Text = "...";
            this.btnchoix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnchoix.UseVisualStyleBackColor = true;
            this.btnchoix.Click += new System.EventHandler(this.btnchoix_Click);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnvoyer.Location = new System.Drawing.Point(385, 359);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(317, 51);
            this.btnEnvoyer.TabIndex = 14;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Abandonner ce fichier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Envoyer à";
            // 
            // lblObjet
            // 
            this.lblObjet.AutoSize = true;
            this.lblObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblObjet.Location = new System.Drawing.Point(179, 38);
            this.lblObjet.Name = "lblObjet";
            this.lblObjet.Size = new System.Drawing.Size(385, 31);
            this.lblObjet.TabIndex = 19;
            this.lblObjet.Text = "Demande de note de service";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(263, 227);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(398, 1);
            this.panel8.TabIndex = 36;
            // 
            // txtDestinataire
            // 
            this.txtDestinataire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.txtDestinataire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinataire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinataire.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDestinataire.Location = new System.Drawing.Point(263, 193);
            this.txtDestinataire.Multiline = true;
            this.txtDestinataire.Name = "txtDestinataire";
            this.txtDestinataire.Size = new System.Drawing.Size(394, 35);
            this.txtDestinataire.TabIndex = 35;
            this.txtDestinataire.Text = "Email";
            this.txtDestinataire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDestinataire.Enter += new System.EventHandler(this.txtDestinataire_Enter);
            // 
            // FRM_EnvoiD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtDestinataire);
            this.Controls.Add(this.lblObjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.btnchoix);
            this.Controls.Add(this.textBoxFichier);
            this.Controls.Add(this.lblFichier);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_EnvoiD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Publication";
            this.Load += new System.EventHandler(this.FRM_Publication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFichier;
        private System.Windows.Forms.TextBox textBoxFichier;
        private System.Windows.Forms.Button btnchoix;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblObjet;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox txtDestinataire;
    }
}