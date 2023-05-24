namespace AP3_GestionHackathon
{
    partial class FormHackathon
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvHackathon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirLesÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BSHackathon = new System.Windows.Forms.BindingSource(this.components);
            this.BSEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAtelier = new System.Windows.Forms.DataGridView();
            this.bSup = new System.Windows.Forms.Button();
            this.BSAtelier = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHackathon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSHackathon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtelier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSAtelier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHackathon
            // 
            this.dgvHackathon.AllowUserToAddRows = false;
            this.dgvHackathon.AllowUserToDeleteRows = false;
            this.dgvHackathon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHackathon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHackathon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHackathon.Location = new System.Drawing.Point(12, 46);
            this.dgvHackathon.MultiSelect = false;
            this.dgvHackathon.Name = "dgvHackathon";
            this.dgvHackathon.ReadOnly = true;
            this.dgvHackathon.RowHeadersWidth = 51;
            this.dgvHackathon.Size = new System.Drawing.Size(504, 258);
            this.dgvHackathon.TabIndex = 0;
            this.dgvHackathon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHackathon_CellContentClick);
            this.dgvHackathon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHackathon_CellContentClick);
            this.dgvHackathon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvHackathon_CellMouseClick);
            this.dgvHackathon.Click += new System.EventHandler(this.DgvHackathon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesÉquipesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // voirLesÉquipesToolStripMenuItem
            // 
            this.voirLesÉquipesToolStripMenuItem.Name = "voirLesÉquipesToolStripMenuItem";
            this.voirLesÉquipesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.voirLesÉquipesToolStripMenuItem.Text = "Voir les équipes";
            this.voirLesÉquipesToolStripMenuItem.Click += new System.EventHandler(this.VoirLesÉquipesToolStripMenuItem_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(672, 323);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 1;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des Hackathons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "click droit sur l\'hackathon sélectionné pour voir ses équipes";
            // 
            // BSHackathon
            // 
            this.BSHackathon.CurrentChanged += new System.EventHandler(this.BSHackathon_CurrentChanged);
            // 
            // dgvAtelier
            // 
            this.dgvAtelier.AllowUserToAddRows = false;
            this.dgvAtelier.AllowUserToDeleteRows = false;
            this.dgvAtelier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtelier.Location = new System.Drawing.Point(522, 46);
            this.dgvAtelier.Name = "dgvAtelier";
            this.dgvAtelier.ReadOnly = true;
            this.dgvAtelier.RowHeadersWidth = 51;
            this.dgvAtelier.Size = new System.Drawing.Size(259, 258);
            this.dgvAtelier.TabIndex = 5;
            this.dgvAtelier.Visible = false;
            this.dgvAtelier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipes_CellContentClick);
            // 
            // bSup
            // 
            this.bSup.BackColor = System.Drawing.Color.Black;
            this.bSup.Enabled = false;
            this.bSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSup.Location = new System.Drawing.Point(558, 323);
            this.bSup.Name = "bSup";
            this.bSup.Size = new System.Drawing.Size(95, 51);
            this.bSup.TabIndex = 7;
            this.bSup.Text = "Supprimer";
            this.bSup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSup.UseVisualStyleBackColor = true;
            this.bSup.Click += new System.EventHandler(this.bSup_Click);
            // 
            // FormHackathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.bSup);
            this.Controls.Add(this.dgvAtelier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dgvHackathon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHackathon";
            this.Text = "Gestion des Hackathons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHackathon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BSHackathon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtelier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSAtelier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BSHackathon;
        private System.Windows.Forms.DataGridView dgvHackathon;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voirLesÉquipesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.DataGridView dgvAtelier;
        private System.Windows.Forms.Button bSup;
        private System.Windows.Forms.BindingSource BSAtelier;
    }
}

