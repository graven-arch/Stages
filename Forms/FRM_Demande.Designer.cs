
namespace Gestion_Note.Forms
{
    partial class FRM_Demande
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAjouterModifierD = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.lblDateDe = new System.Windows.Forms.Label();
            this.lblObjectifD = new System.Windows.Forms.Label();
            this.txtObjectif = new System.Windows.Forms.RichTextBox();
            this.lblDatePriseEffet = new System.Windows.Forms.Label();
            this.lblDatePublicationDe = new System.Windows.Forms.Label();
            this.dtpDatePublicationDe = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePriseEffetDe = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDemande = new System.Windows.Forms.DateTimePicker();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(711, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 430);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 3);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 427);
            this.panel4.TabIndex = 1;
            // 
            // lblAjouterModifierD
            // 
            this.lblAjouterModifierD.AutoSize = true;
            this.lblAjouterModifierD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.lblAjouterModifierD.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterModifierD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAjouterModifierD.Location = new System.Drawing.Point(231, 27);
            this.lblAjouterModifierD.Name = "lblAjouterModifierD";
            this.lblAjouterModifierD.Size = new System.Drawing.Size(255, 33);
            this.lblAjouterModifierD.TabIndex = 48;
            this.lblAjouterModifierD.Text = "Ajouter Demande";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(409, 366);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(229, 43);
            this.btnAjouter.TabIndex = 51;
            this.btnAjouter.Text = "Enregistrer";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.DarkCyan;
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualiser.Location = new System.Drawing.Point(90, 366);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(229, 43);
            this.btnActualiser.TabIndex = 50;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // lblDateDe
            // 
            this.lblDateDe.AutoSize = true;
            this.lblDateDe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateDe.Location = new System.Drawing.Point(9, 91);
            this.lblDateDe.Name = "lblDateDe";
            this.lblDateDe.Size = new System.Drawing.Size(151, 23);
            this.lblDateDe.TabIndex = 53;
            this.lblDateDe.Text = "Date Demande";
            // 
            // lblObjectifD
            // 
            this.lblObjectifD.AutoSize = true;
            this.lblObjectifD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectifD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObjectifD.Location = new System.Drawing.Point(3, 264);
            this.lblObjectifD.Name = "lblObjectifD";
            this.lblObjectifD.Size = new System.Drawing.Size(84, 23);
            this.lblObjectifD.TabIndex = 54;
            this.lblObjectifD.Text = "Objectif";
            // 
            // txtObjectif
            // 
            this.txtObjectif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObjectif.Location = new System.Drawing.Point(88, 197);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(583, 147);
            this.txtObjectif.TabIndex = 55;
            this.txtObjectif.Text = "";
            // 
            // lblDatePriseEffet
            // 
            this.lblDatePriseEffet.AutoSize = true;
            this.lblDatePriseEffet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePriseEffet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatePriseEffet.Location = new System.Drawing.Point(540, 91);
            this.lblDatePriseEffet.Name = "lblDatePriseEffet";
            this.lblDatePriseEffet.Size = new System.Drawing.Size(144, 23);
            this.lblDatePriseEffet.TabIndex = 56;
            this.lblDatePriseEffet.Text = "Date Prise Effet";
            // 
            // lblDatePublicationDe
            // 
            this.lblDatePublicationDe.AutoSize = true;
            this.lblDatePublicationDe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePublicationDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatePublicationDe.Location = new System.Drawing.Point(274, 91);
            this.lblDatePublicationDe.Name = "lblDatePublicationDe";
            this.lblDatePublicationDe.Size = new System.Drawing.Size(163, 23);
            this.lblDatePublicationDe.TabIndex = 57;
            this.lblDatePublicationDe.Text = "Date Publication";
            this.lblDatePublicationDe.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDatePublicationDe
            // 
            this.dtpDatePublicationDe.CustomFormat = "yyyy.MM.dd";
            this.dtpDatePublicationDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePublicationDe.Location = new System.Drawing.Point(243, 117);
            this.dtpDatePublicationDe.Name = "dtpDatePublicationDe";
            this.dtpDatePublicationDe.Size = new System.Drawing.Size(230, 20);
            this.dtpDatePublicationDe.TabIndex = 58;
            // 
            // dtpDatePriseEffetDe
            // 
            this.dtpDatePriseEffetDe.CustomFormat = "yyyy.MM.dd";
            this.dtpDatePriseEffetDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePriseEffetDe.Location = new System.Drawing.Point(479, 117);
            this.dtpDatePriseEffetDe.Name = "dtpDatePriseEffetDe";
            this.dtpDatePriseEffetDe.Size = new System.Drawing.Size(230, 20);
            this.dtpDatePriseEffetDe.TabIndex = 59;
            // 
            // dtpDateDemande
            // 
            this.dtpDateDemande.CustomFormat = "yyyy.MM.dd";
            this.dtpDateDemande.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDemande.Location = new System.Drawing.Point(7, 117);
            this.dtpDateDemande.Name = "dtpDateDemande";
            this.dtpDateDemande.Size = new System.Drawing.Size(230, 20);
            this.dtpDateDemande.TabIndex = 61;
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
            this.btnQuit.TabIndex = 60;
            this.btnQuit.TabStop = false;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FRM_Demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.dtpDateDemande);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dtpDatePriseEffetDe);
            this.Controls.Add(this.dtpDatePublicationDe);
            this.Controls.Add(this.lblDatePublicationDe);
            this.Controls.Add(this.lblDatePriseEffet);
            this.Controls.Add(this.txtObjectif);
            this.Controls.Add(this.lblObjectifD);
            this.Controls.Add(this.lblDateDe);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.lblAjouterModifierD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Demande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AjouterDemande";
            this.Load += new System.EventHandler(this.FRM_Demande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDateDe;
        private System.Windows.Forms.Label lblObjectifD;
        private System.Windows.Forms.Label lblDatePriseEffet;
        private System.Windows.Forms.Label lblDatePublicationDe;
        private System.Windows.Forms.Button btnQuit;
        public System.Windows.Forms.Label lblAjouterModifierD;
        public System.Windows.Forms.Button btnActualiser;
        public System.Windows.Forms.DateTimePicker dtpDatePublicationDe;
        public System.Windows.Forms.DateTimePicker dtpDatePriseEffetDe;
        public System.Windows.Forms.DateTimePicker dtpDateDemande;
        public System.Windows.Forms.RichTextBox txtObjectif;
    }
}