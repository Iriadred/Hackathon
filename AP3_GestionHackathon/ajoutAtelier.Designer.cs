
namespace AP3_GestionHackathon
{
    partial class ajoutAtelier
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
            this.TxtAtelier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAtelier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHack = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.btAjout = new System.Windows.Forms.Button();
            this.btAnnul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UDnb = new System.Windows.Forms.NumericUpDown();
            this.BSatelier = new System.Windows.Forms.BindingSource(this.components);
            this.BShack = new System.Windows.Forms.BindingSource(this.components);
            this.gbSalle = new System.Windows.Forms.GroupBox();
            this.txtSalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDnb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSatelier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BShack)).BeginInit();
            this.gbSalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAtelier
            // 
            this.TxtAtelier.Location = new System.Drawing.Point(41, 54);
            this.TxtAtelier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAtelier.Name = "TxtAtelier";
            this.TxtAtelier.Size = new System.Drawing.Size(168, 20);
            this.TxtAtelier.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nom atelier *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre de place de atelier *";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(41, 207);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(168, 20);
            this.dtpDebut.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Date début atelier*";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(41, 274);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(168, 20);
            this.dtpFin.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date fin atelier*";
            // 
            // cbAtelier
            // 
            this.cbAtelier.FormattingEnabled = true;
            this.cbAtelier.Location = new System.Drawing.Point(333, 51);
            this.cbAtelier.Margin = new System.Windows.Forms.Padding(2);
            this.cbAtelier.Name = "cbAtelier";
            this.cbAtelier.Size = new System.Drawing.Size(151, 21);
            this.cbAtelier.TabIndex = 35;
            this.cbAtelier.SelectedIndexChanged += new System.EventHandler(this.cbAtelier_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nom salle *";
            // 
            // cbHack
            // 
            this.cbHack.FormattingEnabled = true;
            this.cbHack.Location = new System.Drawing.Point(333, 133);
            this.cbHack.Margin = new System.Windows.Forms.Padding(2);
            this.cbHack.Name = "cbHack";
            this.cbHack.Size = new System.Drawing.Size(151, 21);
            this.cbHack.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "liste Hackathon *";
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(389, 274);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 39;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            // 
            // btAjout
            // 
            this.btAjout.BackColor = System.Drawing.Color.Black;
            this.btAjout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjout.Location = new System.Drawing.Point(497, 274);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(95, 51);
            this.btAjout.TabIndex = 40;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = false;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // btAnnul
            // 
            this.btAnnul.BackColor = System.Drawing.Color.Black;
            this.btAnnul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnnul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAnnul.Location = new System.Drawing.Point(272, 274);
            this.btAnnul.Name = "btAnnul";
            this.btAnnul.Size = new System.Drawing.Size(95, 51);
            this.btAnnul.TabIndex = 41;
            this.btAnnul.Text = "Annuler";
            this.btAnnul.UseVisualStyleBackColor = false;
            this.btAnnul.Click += new System.EventHandler(this.btAnnul_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(497, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UDnb
            // 
            this.UDnb.Location = new System.Drawing.Point(41, 134);
            this.UDnb.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UDnb.Name = "UDnb";
            this.UDnb.Size = new System.Drawing.Size(142, 20);
            this.UDnb.TabIndex = 43;
            // 
            // gbSalle
            // 
            this.gbSalle.Controls.Add(this.button3);
            this.gbSalle.Controls.Add(this.button2);
            this.gbSalle.Controls.Add(this.label6);
            this.gbSalle.Controls.Add(this.txtSalle);
            this.gbSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalle.ForeColor = System.Drawing.Color.White;
            this.gbSalle.Location = new System.Drawing.Point(523, 37);
            this.gbSalle.Name = "gbSalle";
            this.gbSalle.Size = new System.Drawing.Size(211, 222);
            this.gbSalle.TabIndex = 44;
            this.gbSalle.TabStop = false;
            this.gbSalle.Text = "Ajouter une salle";
            this.gbSalle.Visible = false;
            // 
            // txtSalle
            // 
            this.txtSalle.Location = new System.Drawing.Point(21, 73);
            this.txtSalle.Name = "txtSalle";
            this.txtSalle.Size = new System.Drawing.Size(170, 22);
            this.txtSalle.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nom de la salle";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(6, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 51);
            this.button2.TabIndex = 45;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(107, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 51);
            this.button3.TabIndex = 46;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ajoutAtelier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(763, 353);
            this.Controls.Add(this.gbSalle);
            this.Controls.Add(this.UDnb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAnnul);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAtelier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtAtelier);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ajoutAtelier";
            this.Text = "ajoutAtelier";
            ((System.ComponentModel.ISupportInitialize)(this.UDnb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSatelier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BShack)).EndInit();
            this.gbSalle.ResumeLayout(false);
            this.gbSalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAtelier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAtelier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Button btAnnul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource BSatelier;
        private System.Windows.Forms.BindingSource BShack;
        private System.Windows.Forms.NumericUpDown UDnb;
        private System.Windows.Forms.GroupBox gbSalle;
        private System.Windows.Forms.TextBox txtSalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}