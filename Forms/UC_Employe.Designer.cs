
namespace Gestion_Note.Forms
{
    partial class UC_Employe
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
            System.Windows.Forms.Button btnSupprimerE;
            System.Windows.Forms.Button btnModifierE;
            System.Windows.Forms.Button btnAjouterE;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button btnImprimerE;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvEmploye = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnSupprimerE = new System.Windows.Forms.Button();
            btnModifierE = new System.Windows.Forms.Button();
            btnAjouterE = new System.Windows.Forms.Button();
            btnImprimerE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimerE
            // 
            btnSupprimerE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSupprimerE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnSupprimerE.FlatAppearance.BorderSize = 0;
            btnSupprimerE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSupprimerE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSupprimerE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSupprimerE.Image = global::Gestion_Note.Properties.Resources.close__1_;
            btnSupprimerE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSupprimerE.Location = new System.Drawing.Point(652, 27);
            btnSupprimerE.Name = "btnSupprimerE";
            btnSupprimerE.Size = new System.Drawing.Size(243, 58);
            btnSupprimerE.TabIndex = 15;
            btnSupprimerE.Text = "Supprimer";
            btnSupprimerE.UseVisualStyleBackColor = false;
            btnSupprimerE.Click += new System.EventHandler(this.btnSupprimerE_Click);
            // 
            // btnModifierE
            // 
            btnModifierE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnModifierE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnModifierE.FlatAppearance.BorderSize = 0;
            btnModifierE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModifierE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModifierE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnModifierE.Image = global::Gestion_Note.Properties.Resources.edit__6_1;
            btnModifierE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnModifierE.Location = new System.Drawing.Point(341, 27);
            btnModifierE.Name = "btnModifierE";
            btnModifierE.Size = new System.Drawing.Size(243, 58);
            btnModifierE.TabIndex = 14;
            btnModifierE.Text = "Modifier";
            btnModifierE.UseVisualStyleBackColor = false;
            btnModifierE.Click += new System.EventHandler(this.btnModifierE_Click);
            // 
            // btnAjouterE
            // 
            btnAjouterE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnAjouterE.FlatAppearance.BorderSize = 0;
            btnAjouterE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAjouterE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAjouterE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAjouterE.Image = global::Gestion_Note.Properties.Resources.plus;
            btnAjouterE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAjouterE.Location = new System.Drawing.Point(37, 27);
            btnAjouterE.Name = "btnAjouterE";
            btnAjouterE.Size = new System.Drawing.Size(243, 58);
            btnAjouterE.TabIndex = 13;
            btnAjouterE.Text = "Ajouter";
            btnAjouterE.UseVisualStyleBackColor = false;
            btnAjouterE.Click += new System.EventHandler(this.btnAjouterE_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 597);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(932, 3);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkCyan;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(929, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(3, 597);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.DarkCyan;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(926, 3);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.DarkCyan;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(3, 597);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // cbRecherche
            // 
            this.cbRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecherche.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Email",
            "Nature",
            "Departement"});
            this.cbRecherche.Location = new System.Drawing.Point(138, 130);
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.Size = new System.Drawing.Size(310, 38);
            this.cbRecherche.TabIndex = 20;
            this.cbRecherche.SelectedIndexChanged += new System.EventHandler(this.cbRecherche_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel7.Location = new System.Drawing.Point(529, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 3);
            this.panel7.TabIndex = 19;
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
            this.txtRecherche.TabIndex = 18;
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
            this.panel6.TabIndex = 17;
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
            this.panel5.TabIndex = 16;
            // 
            // dgvEmploye
            // 
            this.dgvEmploye.AllowUserToAddRows = false;
            this.dgvEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmploye.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmploye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmploye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEmploye.EnableHeadersVisualStyles = false;
            this.dgvEmploye.GridColor = System.Drawing.Color.Silver;
            this.dgvEmploye.Location = new System.Drawing.Point(3, 221);
            this.dgvEmploye.Name = "dgvEmploye";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmploye.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmploye.RowHeadersVisible = false;
            this.dgvEmploye.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmploye.Size = new System.Drawing.Size(926, 297);
            this.dgvEmploye.TabIndex = 21;
            this.dgvEmploye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmploye_CellContentClick);
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
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nature";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Departement";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnImprimerE
            // 
            btnImprimerE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnImprimerE.FlatAppearance.BorderSize = 0;
            btnImprimerE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImprimerE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnImprimerE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnImprimerE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnImprimerE.Location = new System.Drawing.Point(653, 533);
            btnImprimerE.Name = "btnImprimerE";
            btnImprimerE.Size = new System.Drawing.Size(243, 58);
            btnImprimerE.TabIndex = 33;
            btnImprimerE.Text = "Imprimer la liste des Employés";
            btnImprimerE.UseVisualStyleBackColor = false;
            btnImprimerE.Click += new System.EventHandler(this.btnImprimerE_Click);
            // 
            // UC_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(btnImprimerE);
            this.Controls.Add(this.dgvEmploye);
            this.Controls.Add(this.cbRecherche);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(btnSupprimerE);
            this.Controls.Add(btnModifierE);
            this.Controls.Add(btnAjouterE);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Employe";
            this.Size = new System.Drawing.Size(932, 600);
            this.Load += new System.EventHandler(this.UC_Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox cbRecherche;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvEmploye;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
