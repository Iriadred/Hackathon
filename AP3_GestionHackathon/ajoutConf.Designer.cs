
namespace AP3_GestionHackathon
{
    partial class ajoutConf
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
            this.gbSalle = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.gbParti = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cbHack = new System.Windows.Forms.ComboBox();
            this.cbConf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BSatelier = new System.Windows.Forms.BindingSource(this.components);
            this.BSconf = new System.Windows.Forms.BindingSource(this.components);
            this.gbSalle.SuspendLayout();
            this.gbParti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSatelier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSconf)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSalle
            // 
            this.gbSalle.Controls.Add(this.txtPrenom);
            this.gbSalle.Controls.Add(this.label2);
            this.gbSalle.Controls.Add(this.button3);
            this.gbSalle.Controls.Add(this.button2);
            this.gbSalle.Controls.Add(this.label6);
            this.gbSalle.Controls.Add(this.txtNom);
            this.gbSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalle.ForeColor = System.Drawing.Color.White;
            this.gbSalle.Location = new System.Drawing.Point(12, 51);
            this.gbSalle.Name = "gbSalle";
            this.gbSalle.Size = new System.Drawing.Size(211, 290);
            this.gbSalle.TabIndex = 45;
            this.gbSalle.TabStop = false;
            this.gbSalle.Text = "Ajouter un confériencier";
            this.gbSalle.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(110, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 51);
            this.button3.TabIndex = 46;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(6, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 51);
            this.button2.TabIndex = 45;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nom du conférencier";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(22, 59);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(170, 22);
            this.txtNom.TabIndex = 1;
            // 
            // gbParti
            // 
            this.gbParti.Controls.Add(this.label3);
            this.gbParti.Controls.Add(this.cbConf);
            this.gbParti.Controls.Add(this.cbHack);
            this.gbParti.Controls.Add(this.button1);
            this.gbParti.Controls.Add(this.button4);
            this.gbParti.Controls.Add(this.label1);
            this.gbParti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParti.ForeColor = System.Drawing.Color.White;
            this.gbParti.Location = new System.Drawing.Point(281, 51);
            this.gbParti.Name = "gbParti";
            this.gbParti.Size = new System.Drawing.Size(211, 290);
            this.gbParti.TabIndex = 47;
            this.gbParti.TabStop = false;
            this.gbParti.Text = "Ajouter une participation";
            this.gbParti.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(107, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 51);
            this.button1.TabIndex = 46;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(6, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 51);
            this.button4.TabIndex = 45;
            this.button4.Text = "Fermer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "choisir un atelier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Prenom du conférencier";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(22, 147);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(170, 22);
            this.txtPrenom.TabIndex = 48;
            // 
            // cbHack
            // 
            this.cbHack.FormattingEnabled = true;
            this.cbHack.Location = new System.Drawing.Point(30, 59);
            this.cbHack.Margin = new System.Windows.Forms.Padding(2);
            this.cbHack.Name = "cbHack";
            this.cbHack.Size = new System.Drawing.Size(151, 24);
            this.cbHack.TabIndex = 47;
            // 
            // cbConf
            // 
            this.cbConf.FormattingEnabled = true;
            this.cbConf.Location = new System.Drawing.Point(30, 147);
            this.cbConf.Margin = new System.Windows.Forms.Padding(2);
            this.cbConf.Name = "cbConf";
            this.cbConf.Size = new System.Drawing.Size(151, 24);
            this.cbConf.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "choisir un conférencier";
            // 
            // ajoutConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(760, 353);
            this.Controls.Add(this.gbParti);
            this.Controls.Add(this.gbSalle);
            this.Name = "ajoutConf";
            this.Text = "ajoutConf";
            this.gbSalle.ResumeLayout(false);
            this.gbSalle.PerformLayout();
            this.gbParti.ResumeLayout(false);
            this.gbParti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSatelier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSconf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSalle;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox gbParti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbConf;
        private System.Windows.Forms.ComboBox cbHack;
        private System.Windows.Forms.BindingSource BSatelier;
        private System.Windows.Forms.BindingSource BSconf;
    }
}