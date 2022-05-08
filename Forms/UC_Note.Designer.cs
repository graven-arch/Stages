
namespace Gestion_Note.Forms
{
    partial class UC_Note
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnImpNote;
            System.Windows.Forms.Button btnImptt;
            System.Windows.Forms.Button btnenvoi;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button btnSupprimerN;
            System.Windows.Forms.Button btnModifierN;
            System.Windows.Forms.Button btnAjouterN;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnImpNote = new System.Windows.Forms.Button();
            btnImptt = new System.Windows.Forms.Button();
            btnenvoi = new System.Windows.Forms.Button();
            btnSupprimerN = new System.Windows.Forms.Button();
            btnModifierN = new System.Windows.Forms.Button();
            btnAjouterN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImpNote
            // 
            btnImpNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnImpNote.FlatAppearance.BorderSize = 0;
            btnImpNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImpNote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnImpNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnImpNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnImpNote.Location = new System.Drawing.Point(37, 517);
            btnImpNote.Name = "btnImpNote";
            btnImpNote.Size = new System.Drawing.Size(243, 58);
            btnImpNote.TabIndex = 31;
            btnImpNote.Text = "Imprimer la note";
            btnImpNote.UseVisualStyleBackColor = false;
            btnImpNote.Click += new System.EventHandler(this.btnImpNote_Click);
            // 
            // btnImptt
            // 
            btnImptt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnImptt.FlatAppearance.BorderSize = 0;
            btnImptt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImptt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnImptt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnImptt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnImptt.Location = new System.Drawing.Point(341, 517);
            btnImptt.Name = "btnImptt";
            btnImptt.Size = new System.Drawing.Size(243, 58);
            btnImptt.TabIndex = 32;
            btnImptt.Text = "Imprimer toutes les notes";
            btnImptt.UseVisualStyleBackColor = false;
            btnImptt.Click += new System.EventHandler(this.btnImptt_Click);
            // 
            // btnenvoi
            // 
            btnenvoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnenvoi.FlatAppearance.BorderSize = 0;
            btnenvoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnenvoi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnenvoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnenvoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnenvoi.Location = new System.Drawing.Point(652, 517);
            btnenvoi.Name = "btnenvoi";
            btnenvoi.Size = new System.Drawing.Size(243, 58);
            btnenvoi.TabIndex = 33;
            btnenvoi.Text = "Publier une Note";
            btnenvoi.UseVisualStyleBackColor = false;
            btnenvoi.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(929, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 600);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 3);
            this.panel4.TabIndex = 1;
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNote.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column3,
            this.Column2,
            this.Column9,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column8});
            this.dgvNote.EnableHeadersVisualStyles = false;
            this.dgvNote.GridColor = System.Drawing.Color.Silver;
            this.dgvNote.Location = new System.Drawing.Point(3, 221);
            this.dgvNote.Name = "dgvNote";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNote.RowHeadersVisible = false;
            this.dgvNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNote.Size = new System.Drawing.Size(926, 290);
            this.dgvNote.TabIndex = 30;
            this.dgvNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNote_CellContentClick);
            // 
            // cbRecherche
            // 
            this.cbRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecherche.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Items.AddRange(new object[] {
            "Titre",
            "Etape",
            "Remarque"});
            this.cbRecherche.Location = new System.Drawing.Point(138, 130);
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.Size = new System.Drawing.Size(310, 38);
            this.cbRecherche.TabIndex = 29;
            this.cbRecherche.SelectedIndexChanged += new System.EventHandler(this.cbRecherche_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel7.Location = new System.Drawing.Point(529, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 3);
            this.panel7.TabIndex = 28;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.LightGray;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRecherche.Location = new System.Drawing.Point(529, 130);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(298, 33);
            this.txtRecherche.TabIndex = 27;
            this.txtRecherche.Text = "Recherche";
            this.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel6.Location = new System.Drawing.Point(38, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(858, 3);
            this.panel6.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel5.Location = new System.Drawing.Point(37, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(858, 3);
            this.panel5.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selectionner";
            this.Column1.Name = "Column1";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Identifiant";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Etape";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Titre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Libellé";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Departement concerné";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Remarque";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Publication";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Rédacteur";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnSupprimerN
            // 
            btnSupprimerN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSupprimerN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnSupprimerN.FlatAppearance.BorderSize = 0;
            btnSupprimerN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSupprimerN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSupprimerN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSupprimerN.Image = global::Gestion_Note.Properties.Resources.close__1_;
            btnSupprimerN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSupprimerN.Location = new System.Drawing.Point(652, 27);
            btnSupprimerN.Name = "btnSupprimerN";
            btnSupprimerN.Size = new System.Drawing.Size(243, 58);
            btnSupprimerN.TabIndex = 24;
            btnSupprimerN.Text = "Supprimer";
            btnSupprimerN.UseVisualStyleBackColor = false;
            btnSupprimerN.Click += new System.EventHandler(this.btnSupprimerN_Click);
            // 
            // btnModifierN
            // 
            btnModifierN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnModifierN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnModifierN.FlatAppearance.BorderSize = 0;
            btnModifierN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModifierN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModifierN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnModifierN.Image = global::Gestion_Note.Properties.Resources.edit__6_;
            btnModifierN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnModifierN.Location = new System.Drawing.Point(341, 27);
            btnModifierN.Name = "btnModifierN";
            btnModifierN.Size = new System.Drawing.Size(243, 58);
            btnModifierN.TabIndex = 23;
            btnModifierN.Text = "Modifier";
            btnModifierN.UseVisualStyleBackColor = false;
            btnModifierN.Click += new System.EventHandler(this.btnModifierN_Click);
            // 
            // btnAjouterN
            // 
            btnAjouterN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnAjouterN.FlatAppearance.BorderSize = 0;
            btnAjouterN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAjouterN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAjouterN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAjouterN.Image = global::Gestion_Note.Properties.Resources.plus;
            btnAjouterN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAjouterN.Location = new System.Drawing.Point(37, 27);
            btnAjouterN.Name = "btnAjouterN";
            btnAjouterN.Size = new System.Drawing.Size(243, 58);
            btnAjouterN.TabIndex = 22;
            btnAjouterN.Text = "Ajouter";
            btnAjouterN.UseVisualStyleBackColor = false;
            btnAjouterN.Click += new System.EventHandler(this.btnAjouterN_Click);
            // 
            // UC_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(btnenvoi);
            this.Controls.Add(btnImptt);
            this.Controls.Add(btnImpNote);
            this.Controls.Add(this.dgvNote);
            this.Controls.Add(this.cbRecherche);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(btnSupprimerN);
            this.Controls.Add(btnModifierN);
            this.Controls.Add(btnAjouterN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Note";
            this.Size = new System.Drawing.Size(932, 600);
            this.Load += new System.EventHandler(this.UC_Note_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.ComboBox cbRecherche;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
