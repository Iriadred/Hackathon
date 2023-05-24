
namespace AP3_GestionHackathon
{
    partial class ListeEquipe
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
            this.components = new System.ComponentModel.Container();
            this.dgvEquipe = new System.Windows.Forms.DataGridView();
            this.BSequipe = new System.Windows.Forms.BindingSource(this.components);
            this.BtnFermer = new System.Windows.Forms.Button();
            this.btnSupEquipe = new System.Windows.Forms.Button();
            this.dgvMembre = new System.Windows.Forms.DataGridView();
            this.dgvHack = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lMembre = new System.Windows.Forms.Label();
            this.lHack = new System.Windows.Forms.Label();
            this.btSupMe = new System.Windows.Forms.Button();
            this.btSupHack = new System.Windows.Forms.Button();
            this.BSmembre = new System.Windows.Forms.BindingSource(this.components);
            this.BShack = new System.Windows.Forms.BindingSource(this.components);
            this.btSupEm = new System.Windows.Forms.Button();
            this.btAnnul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSequipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSmembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BShack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipe
            // 
            this.dgvEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipe.Location = new System.Drawing.Point(-50, 37);
            this.dgvEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEquipe.Name = "dgvEquipe";
            this.dgvEquipe.RowHeadersWidth = 51;
            this.dgvEquipe.RowTemplate.Height = 24;
            this.dgvEquipe.Size = new System.Drawing.Size(353, 249);
            this.dgvEquipe.TabIndex = 0;
            this.dgvEquipe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipe_CellContentClick);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(103, 310);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 5;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // btnSupEquipe
            // 
            this.btnSupEquipe.BackColor = System.Drawing.Color.Black;
            this.btnSupEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupEquipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupEquipe.Location = new System.Drawing.Point(2, 310);
            this.btnSupEquipe.Name = "btnSupEquipe";
            this.btnSupEquipe.Size = new System.Drawing.Size(95, 51);
            this.btnSupEquipe.TabIndex = 6;
            this.btnSupEquipe.Text = "Supprimer équipes";
            this.btnSupEquipe.UseVisualStyleBackColor = false;
            this.btnSupEquipe.Click += new System.EventHandler(this.btnSupEquipe_Click);
            // 
            // dgvMembre
            // 
            this.dgvMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembre.Location = new System.Drawing.Point(308, 37);
            this.dgvMembre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMembre.Name = "dgvMembre";
            this.dgvMembre.RowHeadersWidth = 51;
            this.dgvMembre.RowTemplate.Height = 24;
            this.dgvMembre.Size = new System.Drawing.Size(222, 249);
            this.dgvMembre.TabIndex = 7;
            this.dgvMembre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembre_CellContentClick);
            // 
            // dgvHack
            // 
            this.dgvHack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHack.Location = new System.Drawing.Point(534, 37);
            this.dgvHack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHack.Name = "dgvHack";
            this.dgvHack.RowHeadersWidth = 51;
            this.dgvHack.RowTemplate.Height = 24;
            this.dgvHack.Size = new System.Drawing.Size(244, 249);
            this.dgvHack.TabIndex = 8;
            this.dgvHack.Visible = false;
            this.dgvHack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHack_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liste des équipes";
            // 
            // lMembre
            // 
            this.lMembre.AutoSize = true;
            this.lMembre.Location = new System.Drawing.Point(351, 11);
            this.lMembre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMembre.Name = "lMembre";
            this.lMembre.Size = new System.Drawing.Size(94, 13);
            this.lMembre.TabIndex = 10;
            this.lMembre.Text = "Liste des membres";
            this.lMembre.Visible = false;
            // 
            // lHack
            // 
            this.lHack.AutoSize = true;
            this.lHack.Location = new System.Drawing.Point(553, 11);
            this.lHack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lHack.Name = "lHack";
            this.lHack.Size = new System.Drawing.Size(108, 13);
            this.lHack.TabIndex = 11;
            this.lHack.Text = "Liste des hackathons";
            this.lHack.Visible = false;
            // 
            // btSupMe
            // 
            this.btSupMe.BackColor = System.Drawing.Color.Black;
            this.btSupMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSupMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSupMe.Location = new System.Drawing.Point(317, 314);
            this.btSupMe.Name = "btSupMe";
            this.btSupMe.Size = new System.Drawing.Size(95, 51);
            this.btSupMe.TabIndex = 12;
            this.btSupMe.Text = "Supprimer membres";
            this.btSupMe.UseVisualStyleBackColor = false;
            this.btSupMe.Click += new System.EventHandler(this.btSupMe_Click);
            // 
            // btSupHack
            // 
            this.btSupHack.BackColor = System.Drawing.Color.Black;
            this.btSupHack.Enabled = false;
            this.btSupHack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSupHack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupHack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSupHack.Location = new System.Drawing.Point(564, 306);
            this.btSupHack.Name = "btSupHack";
            this.btSupHack.Size = new System.Drawing.Size(95, 60);
            this.btSupHack.TabIndex = 13;
            this.btSupHack.Text = "Supprimer de l\'hackaton";
            this.btSupHack.UseVisualStyleBackColor = false;
            this.btSupHack.Visible = false;
            this.btSupHack.Click += new System.EventHandler(this.btSupHack_Click);
            // 
            // btSupEm
            // 
            this.btSupEm.BackColor = System.Drawing.Color.Black;
            this.btSupEm.Enabled = false;
            this.btSupEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSupEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupEm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSupEm.Location = new System.Drawing.Point(433, 314);
            this.btSupEm.Name = "btSupEm";
            this.btSupEm.Size = new System.Drawing.Size(95, 51);
            this.btSupEm.TabIndex = 14;
            this.btSupEm.Text = "Supprimer de l\'équipe";
            this.btSupEm.UseVisualStyleBackColor = false;
            this.btSupEm.Visible = false;
            this.btSupEm.Click += new System.EventHandler(this.btSupEm_Click);
            // 
            // btAnnul
            // 
            this.btAnnul.BackColor = System.Drawing.Color.Black;
            this.btAnnul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnnul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAnnul.Location = new System.Drawing.Point(204, 310);
            this.btAnnul.Name = "btAnnul";
            this.btAnnul.Size = new System.Drawing.Size(95, 51);
            this.btAnnul.TabIndex = 15;
            this.btAnnul.Text = "Annuler";
            this.btAnnul.UseVisualStyleBackColor = false;
            this.btAnnul.Visible = false;
            this.btAnnul.Click += new System.EventHandler(this.btAnnul_Click);
            // 
            // ListeEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(787, 385);
            this.Controls.Add(this.btAnnul);
            this.Controls.Add(this.btSupEm);
            this.Controls.Add(this.btSupHack);
            this.Controls.Add(this.btSupMe);
            this.Controls.Add(this.lHack);
            this.Controls.Add(this.lMembre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHack);
            this.Controls.Add(this.dgvMembre);
            this.Controls.Add(this.btnSupEquipe);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dgvEquipe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListeEquipe";
            this.Text = "ListeEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSequipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSmembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BShack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipe;
        private System.Windows.Forms.BindingSource BSequipe;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button btnSupEquipe;
        private System.Windows.Forms.DataGridView dgvMembre;
        private System.Windows.Forms.DataGridView dgvHack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lMembre;
        private System.Windows.Forms.Label lHack;
        private System.Windows.Forms.Button btSupMe;
        private System.Windows.Forms.Button btSupHack;
        private System.Windows.Forms.BindingSource BSmembre;
        private System.Windows.Forms.BindingSource BShack;
        private System.Windows.Forms.Button btSupEm;
        private System.Windows.Forms.Button btAnnul;
    }
}