
namespace Gestion_Note.Forms
{
    partial class FRM_Note
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
            this.lblAjoutNote = new System.Windows.Forms.Label();
            this.lblTitreN = new System.Windows.Forms.Label();
            this.lblEtapeN = new System.Windows.Forms.Label();
            this.cbEtape = new System.Windows.Forms.ComboBox();
            this.txtTitreN = new System.Windows.Forms.TextBox();
            this.lblLibelleN = new System.Windows.Forms.Label();
            this.txtLibelleN = new System.Windows.Forms.RichTextBox();
            this.lblRemarqueN = new System.Windows.Forms.Label();
            this.txtRemarqueN = new System.Windows.Forms.RichTextBox();
            this.btnAjouterN = new System.Windows.Forms.Button();
            this.btnActualiserN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatepublication = new System.Windows.Forms.DateTimePicker();
            this.lblDept = new System.Windows.Forms.Label();
            this.CbdeptNote = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblIdemploye = new System.Windows.Forms.Label();
            this.txtIdemploye = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(692, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 575);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 3);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 572);
            this.panel4.TabIndex = 3;
            // 
            // lblAjoutNote
            // 
            this.lblAjoutNote.AutoSize = true;
            this.lblAjoutNote.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAjoutNote.Location = new System.Drawing.Point(261, 9);
            this.lblAjoutNote.Name = "lblAjoutNote";
            this.lblAjoutNote.Size = new System.Drawing.Size(187, 33);
            this.lblAjoutNote.TabIndex = 4;
            this.lblAjoutNote.Text = "Ajouter Note";
            this.lblAjoutNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitreN
            // 
            this.lblTitreN.AutoSize = true;
            this.lblTitreN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitreN.Location = new System.Drawing.Point(609, 29);
            this.lblTitreN.Name = "lblTitreN";
            this.lblTitreN.Size = new System.Drawing.Size(48, 24);
            this.lblTitreN.TabIndex = 5;
            this.lblTitreN.Text = "Titre";
            // 
            // lblEtapeN
            // 
            this.lblEtapeN.AutoSize = true;
            this.lblEtapeN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapeN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEtapeN.Location = new System.Drawing.Point(28, 29);
            this.lblEtapeN.Name = "lblEtapeN";
            this.lblEtapeN.Size = new System.Drawing.Size(70, 24);
            this.lblEtapeN.TabIndex = 6;
            this.lblEtapeN.Text = "Etape";
            // 
            // cbEtape
            // 
            this.cbEtape.BackColor = System.Drawing.SystemColors.Window;
            this.cbEtape.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEtape.FormattingEnabled = true;
            this.cbEtape.Items.AddRange(new object[] {
            "En rédaction",
            "En approbation",
            "A publier"});
            this.cbEtape.Location = new System.Drawing.Point(27, 59);
            this.cbEtape.Name = "cbEtape";
            this.cbEtape.Size = new System.Drawing.Size(228, 29);
            this.cbEtape.TabIndex = 7;
            // 
            // txtTitreN
            // 
            this.txtTitreN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitreN.Location = new System.Drawing.Point(448, 57);
            this.txtTitreN.Name = "txtTitreN";
            this.txtTitreN.Size = new System.Drawing.Size(228, 27);
            this.txtTitreN.TabIndex = 8;
            // 
            // lblLibelleN
            // 
            this.lblLibelleN.AutoSize = true;
            this.lblLibelleN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLibelleN.Location = new System.Drawing.Point(8, 297);
            this.lblLibelleN.Name = "lblLibelleN";
            this.lblLibelleN.Size = new System.Drawing.Size(75, 24);
            this.lblLibelleN.TabIndex = 9;
            this.lblLibelleN.Text = "Libelle";
            // 
            // txtLibelleN
            // 
            this.txtLibelleN.BackColor = System.Drawing.SystemColors.Window;
            this.txtLibelleN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibelleN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelleN.Location = new System.Drawing.Point(81, 228);
            this.txtLibelleN.Name = "txtLibelleN";
            this.txtLibelleN.Size = new System.Drawing.Size(543, 166);
            this.txtLibelleN.TabIndex = 10;
            this.txtLibelleN.Text = "";
            this.txtLibelleN.TextChanged += new System.EventHandler(this.txtLibelleN_TextChanged);
            // 
            // lblRemarqueN
            // 
            this.lblRemarqueN.AutoSize = true;
            this.lblRemarqueN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarqueN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemarqueN.Location = new System.Drawing.Point(295, 400);
            this.lblRemarqueN.Name = "lblRemarqueN";
            this.lblRemarqueN.Size = new System.Drawing.Size(119, 24);
            this.lblRemarqueN.TabIndex = 11;
            this.lblRemarqueN.Text = "Remarque";
            // 
            // txtRemarqueN
            // 
            this.txtRemarqueN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemarqueN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarqueN.Location = new System.Drawing.Point(81, 427);
            this.txtRemarqueN.Name = "txtRemarqueN";
            this.txtRemarqueN.Size = new System.Drawing.Size(543, 49);
            this.txtRemarqueN.TabIndex = 12;
            this.txtRemarqueN.Text = "";
            // 
            // btnAjouterN
            // 
            this.btnAjouterN.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAjouterN.FlatAppearance.BorderSize = 0;
            this.btnAjouterN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterN.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouterN.Location = new System.Drawing.Point(447, 515);
            this.btnAjouterN.Name = "btnAjouterN";
            this.btnAjouterN.Size = new System.Drawing.Size(229, 43);
            this.btnAjouterN.TabIndex = 51;
            this.btnAjouterN.Text = "Enregistrer";
            this.btnAjouterN.UseVisualStyleBackColor = false;
            this.btnAjouterN.Click += new System.EventHandler(this.btnAjouterN_Click);
            // 
            // btnActualiserN
            // 
            this.btnActualiserN.BackColor = System.Drawing.Color.DarkCyan;
            this.btnActualiserN.FlatAppearance.BorderSize = 0;
            this.btnActualiserN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiserN.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiserN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualiserN.Location = new System.Drawing.Point(133, 515);
            this.btnActualiserN.Name = "btnActualiserN";
            this.btnActualiserN.Size = new System.Drawing.Size(229, 43);
            this.btnActualiserN.TabIndex = 50;
            this.btnActualiserN.Text = "Actualiser";
            this.btnActualiserN.UseVisualStyleBackColor = false;
            this.btnActualiserN.Click += new System.EventHandler(this.btnActualiserN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(497, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date Publication";
            // 
            // dtpDatepublication
            // 
            this.dtpDatepublication.CustomFormat = "yyyy.MM.dd";
            this.dtpDatepublication.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatepublication.Location = new System.Drawing.Point(448, 164);
            this.dtpDatepublication.Name = "dtpDatepublication";
            this.dtpDatepublication.Size = new System.Drawing.Size(228, 20);
            this.dtpDatepublication.TabIndex = 53;
            this.dtpDatepublication.Value = new System.DateTime(2021, 8, 25, 0, 0, 0, 0);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDept.Location = new System.Drawing.Point(23, 134);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(258, 24);
            this.lblDept.TabIndex = 54;
            this.lblDept.Text = "Département concerné";
            // 
            // CbdeptNote
            // 
            this.CbdeptNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbdeptNote.FormattingEnabled = true;
            this.CbdeptNote.Items.AddRange(new object[] {
            "En rédaction",
            "En approbation",
            "A publier"});
            this.CbdeptNote.Location = new System.Drawing.Point(32, 161);
            this.CbdeptNote.Name = "CbdeptNote";
            this.CbdeptNote.Size = new System.Drawing.Size(228, 29);
            this.CbdeptNote.TabIndex = 55;
            this.CbdeptNote.SelectedIndexChanged += new System.EventHandler(this.CbdeptNote_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(250, 508);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(271, 1);
            this.panel9.TabIndex = 57;
            // 
            // lblIdemploye
            // 
            this.lblIdemploye.AutoSize = true;
            this.lblIdemploye.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdemploye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdemploye.Location = new System.Drawing.Point(9, 482);
            this.lblIdemploye.Name = "lblIdemploye";
            this.lblIdemploye.Size = new System.Drawing.Size(136, 24);
            this.lblIdemploye.TabIndex = 58;
            this.lblIdemploye.Text = "Rédigée par";
            // 
            // txtIdemploye
            // 
            this.txtIdemploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.txtIdemploye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdemploye.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtIdemploye.ForeColor = System.Drawing.Color.White;
            this.txtIdemploye.Location = new System.Drawing.Point(250, 482);
            this.txtIdemploye.Multiline = true;
            this.txtIdemploye.Name = "txtIdemploye";
            this.txtIdemploye.Size = new System.Drawing.Size(271, 24);
            this.txtIdemploye.TabIndex = 59;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Image = global::Gestion_Note.Properties.Resources.vcsconflicting_93497;
            this.btnQuit.Location = new System.Drawing.Point(658, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(34, 37);
            this.btnQuit.TabIndex = 61;
            this.btnQuit.TabStop = false;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FRM_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(695, 578);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtIdemploye);
            this.Controls.Add(this.lblIdemploye);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.CbdeptNote);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.dtpDatepublication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouterN);
            this.Controls.Add(this.btnActualiserN);
            this.Controls.Add(this.txtRemarqueN);
            this.Controls.Add(this.lblRemarqueN);
            this.Controls.Add(this.txtLibelleN);
            this.Controls.Add(this.lblLibelleN);
            this.Controls.Add(this.txtTitreN);
            this.Controls.Add(this.cbEtape);
            this.Controls.Add(this.lblEtapeN);
            this.Controls.Add(this.lblTitreN);
            this.Controls.Add(this.lblAjoutNote);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Note";
            this.Load += new System.EventHandler(this.FRM_Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitreN;
        private System.Windows.Forms.Label lblEtapeN;
        private System.Windows.Forms.Label lblLibelleN;
        private System.Windows.Forms.Label lblRemarqueN;
        private System.Windows.Forms.Button btnAjouterN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.Button btnActualiserN;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblIdemploye;
        public System.Windows.Forms.ComboBox cbEtape;
        public System.Windows.Forms.TextBox txtTitreN;
        public System.Windows.Forms.RichTextBox txtLibelleN;
        public System.Windows.Forms.RichTextBox txtRemarqueN;
        public System.Windows.Forms.DateTimePicker dtpDatepublication;
        public System.Windows.Forms.ComboBox CbdeptNote;
        public System.Windows.Forms.TextBox txtIdemploye;
        public System.Windows.Forms.Label lblAjoutNote;
        private System.Windows.Forms.Button btnQuit;
    }
}