
namespace Gestion_Note.Forms
{
    partial class UC_Demande
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnSupprimer;
            System.Windows.Forms.Button btnModifier;
            System.Windows.Forms.Button btnAjouter;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.dgvDemande = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSauvegarger = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemande)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnSupprimer.FlatAppearance.BorderSize = 0;
            btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSupprimer.Location = new System.Drawing.Point(651, 27);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(243, 58);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnModifier.FlatAppearance.BorderSize = 0;
            btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModifier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnModifier.Location = new System.Drawing.Point(340, 27);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new System.Drawing.Size(243, 58);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            btnAjouter.FlatAppearance.BorderSize = 0;
            btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAjouter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAjouter.Location = new System.Drawing.Point(36, 27);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(243, 58);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 597);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 597);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 3);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(929, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 594);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel5.Location = new System.Drawing.Point(36, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(858, 3);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel6.Location = new System.Drawing.Point(37, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(858, 3);
            this.panel6.TabIndex = 8;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.LightGray;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRecherche.Location = new System.Drawing.Point(528, 130);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(298, 33);
            this.txtRecherche.TabIndex = 9;
            this.txtRecherche.Text = "Recherche";
            this.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.panel7.Location = new System.Drawing.Point(528, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 3);
            this.panel7.TabIndex = 11;
            // 
            // cbRecherche
            // 
            this.cbRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecherche.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Items.AddRange(new object[] {
            "Objectif"});
            this.cbRecherche.Location = new System.Drawing.Point(137, 130);
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.Size = new System.Drawing.Size(310, 38);
            this.cbRecherche.TabIndex = 12;
            this.cbRecherche.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvDemande
            // 
            this.dgvDemande.AllowUserToAddRows = false;
            this.dgvDemande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDemande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDemande.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDemande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDemande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvDemande.EnableHeadersVisualStyles = false;
            this.dgvDemande.GridColor = System.Drawing.Color.Silver;
            this.dgvDemande.Location = new System.Drawing.Point(3, 201);
            this.dgvDemande.Name = "dgvDemande";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDemande.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDemande.RowHeadersVisible = false;
            this.dgvDemande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDemande.Size = new System.Drawing.Size(926, 316);
            this.dgvDemande.TabIndex = 13;
            this.dgvDemande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNote_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selectionner";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Identifiant";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Objectif";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date Demande";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date Publication";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Effet";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(667, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSauvegarger
            // 
            this.btnSauvegarger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnSauvegarger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSauvegarger.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSauvegarger.Location = new System.Drawing.Point(384, 533);
            this.btnSauvegarger.Name = "btnSauvegarger";
            this.btnSauvegarger.Size = new System.Drawing.Size(243, 58);
            this.btnSauvegarger.TabIndex = 15;
            this.btnSauvegarger.Text = "Sauvegarder";
            this.btnSauvegarger.UseVisualStyleBackColor = false;
            this.btnSauvegarger.Click += new System.EventHandler(this.btnSauvegarger_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(110, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "liste des demandes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_Demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSauvegarger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDemande);
            this.Controls.Add(this.cbRecherche);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(btnSupprimer);
            this.Controls.Add(btnModifier);
            this.Controls.Add(btnAjouter);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Demande";
            this.Size = new System.Drawing.Size(932, 600);
            this.Load += new System.EventHandler(this.UC_NoteService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbRecherche;
        private System.Windows.Forms.DataGridView dgvDemande;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSauvegarger;
        private System.Windows.Forms.Button button2;
    }
}
