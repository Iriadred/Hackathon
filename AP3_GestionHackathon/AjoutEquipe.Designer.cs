
namespace AP3_GestionHackathon
{
    partial class AjoutEquipe
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
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.txtLien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btAjoutE = new System.Windows.Forms.Button();
            this.btAnnulerE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNomE = new System.Windows.Forms.TextBox();
            this.gbModifier = new System.Windows.Forms.GroupBox();
            this.txtPortfolio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btAnnulM = new System.Windows.Forms.Button();
            this.btAjoutM = new System.Windows.Forms.Button();
            this.cbEquipe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNaiss = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbChoix = new System.Windows.Forms.ComboBox();
            this.BSajout = new System.Windows.Forms.BindingSource(this.components);
            this.BSequipe = new System.Windows.Forms.BindingSource(this.components);
            this.ckPass = new System.Windows.Forms.CheckBox();
            this.gbAjout.SuspendLayout();
            this.gbModifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSajout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSequipe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.ckPass);
            this.gbAjout.Controls.Add(this.txtLien);
            this.gbAjout.Controls.Add(this.label11);
            this.gbAjout.Controls.Add(this.btAjoutE);
            this.gbAjout.Controls.Add(this.btAnnulerE);
            this.gbAjout.Controls.Add(this.label3);
            this.gbAjout.Controls.Add(this.label2);
            this.gbAjout.Controls.Add(this.label1);
            this.gbAjout.Controls.Add(this.txtPassword);
            this.gbAjout.Controls.Add(this.txtLogin);
            this.gbAjout.Controls.Add(this.txtNomE);
            this.gbAjout.Location = new System.Drawing.Point(22, 66);
            this.gbAjout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAjout.Size = new System.Drawing.Size(311, 281);
            this.gbAjout.TabIndex = 0;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Equipe";
            this.gbAjout.Visible = false;
            // 
            // txtLien
            // 
            this.txtLien.Location = new System.Drawing.Point(148, 130);
            this.txtLien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLien.Name = "txtLien";
            this.txtLien.Size = new System.Drawing.Size(126, 20);
            this.txtLien.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(14, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Lien du prototype";
            // 
            // btAjoutE
            // 
            this.btAjoutE.BackColor = System.Drawing.Color.Black;
            this.btAjoutE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAjoutE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjoutE.Location = new System.Drawing.Point(177, 214);
            this.btAjoutE.Name = "btAjoutE";
            this.btAjoutE.Size = new System.Drawing.Size(95, 51);
            this.btAjoutE.TabIndex = 9;
            this.btAjoutE.Text = "Ajouter";
            this.btAjoutE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAjoutE.UseVisualStyleBackColor = true;
            this.btAjoutE.Click += new System.EventHandler(this.btAjoutE_Click);
            // 
            // btAnnulerE
            // 
            this.btAnnulerE.BackColor = System.Drawing.Color.Black;
            this.btAnnulerE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnnulerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnulerE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAnnulerE.Location = new System.Drawing.Point(16, 214);
            this.btAnnulerE.Name = "btAnnulerE";
            this.btAnnulerE.Size = new System.Drawing.Size(95, 51);
            this.btAnnulerE.TabIndex = 8;
            this.btAnnulerE.Text = "Annuler";
            this.btAnnulerE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAnnulerE.UseVisualStyleBackColor = true;
            this.btAnnulerE.Click += new System.EventHandler(this.btAnnulerE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(4, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "mots de passe de l\'équipe*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login de l\'équipe*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom de l\'équipe*";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(148, 82);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(126, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtNomE
            // 
            this.txtNomE.Location = new System.Drawing.Point(148, 33);
            this.txtNomE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomE.Name = "txtNomE";
            this.txtNomE.Size = new System.Drawing.Size(126, 20);
            this.txtNomE.TabIndex = 0;
            // 
            // gbModifier
            // 
            this.gbModifier.Controls.Add(this.txtPortfolio);
            this.gbModifier.Controls.Add(this.label10);
            this.gbModifier.Controls.Add(this.btAnnulM);
            this.gbModifier.Controls.Add(this.btAjoutM);
            this.gbModifier.Controls.Add(this.cbEquipe);
            this.gbModifier.Controls.Add(this.label9);
            this.gbModifier.Controls.Add(this.dtpNaiss);
            this.gbModifier.Controls.Add(this.label8);
            this.gbModifier.Controls.Add(this.txtTel);
            this.gbModifier.Controls.Add(this.label7);
            this.gbModifier.Controls.Add(this.txtEmail);
            this.gbModifier.Controls.Add(this.label6);
            this.gbModifier.Controls.Add(this.txtPrenom);
            this.gbModifier.Controls.Add(this.label5);
            this.gbModifier.Controls.Add(this.label4);
            this.gbModifier.Controls.Add(this.txtNom);
            this.gbModifier.Location = new System.Drawing.Point(356, 66);
            this.gbModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbModifier.Name = "gbModifier";
            this.gbModifier.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbModifier.Size = new System.Drawing.Size(422, 281);
            this.gbModifier.TabIndex = 1;
            this.gbModifier.TabStop = false;
            this.gbModifier.Text = "membre";
            this.gbModifier.Visible = false;
            // 
            // txtPortfolio
            // 
            this.txtPortfolio.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.txtPortfolio.Location = new System.Drawing.Point(118, 239);
            this.txtPortfolio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPortfolio.Name = "txtPortfolio";
            this.txtPortfolio.Size = new System.Drawing.Size(162, 20);
            this.txtPortfolio.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(46, 243);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Lien portfolio";
            // 
            // btAnnulM
            // 
            this.btAnnulM.BackColor = System.Drawing.Color.Black;
            this.btAnnulM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnnulM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnulM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAnnulM.Location = new System.Drawing.Point(310, 139);
            this.btAnnulM.Name = "btAnnulM";
            this.btAnnulM.Size = new System.Drawing.Size(95, 51);
            this.btAnnulM.TabIndex = 10;
            this.btAnnulM.Text = "Annuler";
            this.btAnnulM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAnnulM.UseVisualStyleBackColor = true;
            this.btAnnulM.Click += new System.EventHandler(this.btAnnulM_Click);
            // 
            // btAjoutM
            // 
            this.btAjoutM.BackColor = System.Drawing.Color.Black;
            this.btAjoutM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAjoutM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjoutM.Location = new System.Drawing.Point(310, 206);
            this.btAjoutM.Name = "btAjoutM";
            this.btAjoutM.Size = new System.Drawing.Size(95, 51);
            this.btAjoutM.TabIndex = 10;
            this.btAjoutM.Text = "Ajouter";
            this.btAjoutM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAjoutM.UseVisualStyleBackColor = true;
            this.btAjoutM.Click += new System.EventHandler(this.btAjoutM_Click);
            // 
            // cbEquipe
            // 
            this.cbEquipe.FormattingEnabled = true;
            this.cbEquipe.Location = new System.Drawing.Point(118, 206);
            this.cbEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEquipe.Name = "cbEquipe";
            this.cbEquipe.Size = new System.Drawing.Size(162, 21);
            this.cbEquipe.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(76, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "équipe";
            // 
            // dtpNaiss
            // 
            this.dtpNaiss.Location = new System.Drawing.Point(119, 172);
            this.dtpNaiss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNaiss.Name = "dtpNaiss";
            this.dtpNaiss.Size = new System.Drawing.Size(161, 20);
            this.dtpNaiss.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(21, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "date de naissance";
            // 
            // txtTel
            // 
            this.txtTel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.txtTel.Location = new System.Drawing.Point(118, 140);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(162, 20);
            this.txtTel.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(4, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "téléphone du membre";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.txtEmail.Location = new System.Drawing.Point(118, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(27, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "email du membre";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(118, 72);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(162, 20);
            this.txtPrenom.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prenom du membre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(30, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nom du membre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(118, 33);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(162, 20);
            this.txtNom.TabIndex = 10;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbChoix
            // 
            this.cbChoix.Enabled = false;
            this.cbChoix.FormattingEnabled = true;
            this.cbChoix.Location = new System.Drawing.Point(126, 11);
            this.cbChoix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChoix.Name = "cbChoix";
            this.cbChoix.Size = new System.Drawing.Size(653, 21);
            this.cbChoix.TabIndex = 2;
            this.cbChoix.SelectedIndexChanged += new System.EventHandler(this.cbChoix_SelectedIndexChanged);
            // 
            // BSajout
            // 
            this.BSajout.CurrentItemChanged += new System.EventHandler(this.BSajout_CurrentItemChanged);
            // 
            // ckPass
            // 
            this.ckPass.AutoSize = true;
            this.ckPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckPass.Location = new System.Drawing.Point(278, 175);
            this.ckPass.Margin = new System.Windows.Forms.Padding(2);
            this.ckPass.Name = "ckPass";
            this.ckPass.Size = new System.Drawing.Size(15, 14);
            this.ckPass.TabIndex = 12;
            this.ckPass.UseVisualStyleBackColor = false;
            this.ckPass.CheckedChanged += new System.EventHandler(this.ckPass_CheckedChanged);
            // 
            // AjoutEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(787, 385);
            this.Controls.Add(this.cbChoix);
            this.Controls.Add(this.gbModifier);
            this.Controls.Add(this.gbAjout);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjoutEquipe";
            this.Text = "AjoutEquipe";
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.gbModifier.ResumeLayout(false);
            this.gbModifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSajout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSequipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNomE;
        private System.Windows.Forms.GroupBox gbModifier;
        private System.Windows.Forms.ComboBox cbChoix;
        private System.Windows.Forms.Button btAjoutE;
        private System.Windows.Forms.Button btAnnulerE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cbEquipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNaiss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAnnulM;
        private System.Windows.Forms.Button btAjoutM;
        private System.Windows.Forms.BindingSource BSajout;
        private System.Windows.Forms.BindingSource BSequipe;
        private System.Windows.Forms.TextBox txtPortfolio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckPass;
    }
}