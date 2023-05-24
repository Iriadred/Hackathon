
namespace AP3_GestionHackathon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.btnconn = new System.Windows.Forms.Button();
            this.ckPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 420);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(208, 119);
            this.txtlog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(159, 20);
            this.txtlog.TabIndex = 4;
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(208, 168);
            this.txtmdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(159, 20);
            this.txtmdp.TabIndex = 5;
            this.txtmdp.TextChanged += new System.EventHandler(this.txtmdp_TextChanged_1);
            // 
            // btnconn
            // 
            this.btnconn.Location = new System.Drawing.Point(244, 223);
            this.btnconn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnconn.Name = "btnconn";
            this.btnconn.Size = new System.Drawing.Size(91, 19);
            this.btnconn.TabIndex = 6;
            this.btnconn.Text = "connexion";
            this.btnconn.UseVisualStyleBackColor = true;
            this.btnconn.Click += new System.EventHandler(this.btnconn_Click_1);
            // 
            // ckPass
            // 
            this.ckPass.AutoSize = true;
            this.ckPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckPass.Location = new System.Drawing.Point(370, 172);
            this.ckPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckPass.Name = "ckPass";
            this.ckPass.Size = new System.Drawing.Size(15, 14);
            this.ckPass.TabIndex = 7;
            this.ckPass.UseVisualStyleBackColor = false;
            this.ckPass.CheckedChanged += new System.EventHandler(this.ckPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ckPass);
            this.Controls.Add(this.btnconn);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "HACKAT\'INNOV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.Button btnconn;
        private System.Windows.Forms.CheckBox ckPass;
    }
}