namespace AP3_GestionHackathon
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.hACKATHONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAtelierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUIPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ajouterConférencierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleParticipationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hACKATHONToolStripMenuItem,
            this.eQUIPEToolStripMenuItem,
            this.qUITTERToolStripMenuItem,
            this.déconexionToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // hACKATHONToolStripMenuItem
            // 
            this.hACKATHONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesHackathonsToolStripMenuItem,
            this.gestionDesHackathonsToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.ajouterAtelierToolStripMenuItem,
            this.ajouterConférencierToolStripMenuItem,
            this.nouvelleParticipationToolStripMenuItem});
            this.hACKATHONToolStripMenuItem.Name = "hACKATHONToolStripMenuItem";
            this.hACKATHONToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.hACKATHONToolStripMenuItem.Text = "hackathons";
            this.hACKATHONToolStripMenuItem.Click += new System.EventHandler(this.hACKATHONToolStripMenuItem_Click);
            // 
            // listeDesHackathonsToolStripMenuItem
            // 
            this.listeDesHackathonsToolStripMenuItem.Name = "listeDesHackathonsToolStripMenuItem";
            this.listeDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listeDesHackathonsToolStripMenuItem.Text = "Liste des hackathons";
            this.listeDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.ListeDesHackathonsToolStripMenuItem_Click);
            // 
            // gestionDesHackathonsToolStripMenuItem
            // 
            this.gestionDesHackathonsToolStripMenuItem.Name = "gestionDesHackathonsToolStripMenuItem";
            this.gestionDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesHackathonsToolStripMenuItem.Text = "Ajout d\'un hackathon";
            this.gestionDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.GestionDesHackathonsToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.ModificationToolStripMenuItem_Click);
            // 
            // ajouterAtelierToolStripMenuItem
            // 
            this.ajouterAtelierToolStripMenuItem.Name = "ajouterAtelierToolStripMenuItem";
            this.ajouterAtelierToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ajouterAtelierToolStripMenuItem.Text = "Ajouter atelier";
            this.ajouterAtelierToolStripMenuItem.Click += new System.EventHandler(this.ajouterAtelierToolStripMenuItem_Click);
            // 
            // eQUIPEToolStripMenuItem
            // 
            this.eQUIPEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesÉquipesToolStripMenuItem,
            this.ajoutÉquipeToolStripMenuItem,
            this.ajoutMembreToolStripMenuItem,
            this.modifierÉquipeToolStripMenuItem,
            this.modifierMembreToolStripMenuItem});
            this.eQUIPEToolStripMenuItem.Name = "eQUIPEToolStripMenuItem";
            this.eQUIPEToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eQUIPEToolStripMenuItem.Text = "équipe";
            this.eQUIPEToolStripMenuItem.Click += new System.EventHandler(this.eQUIPEToolStripMenuItem_Click);
            // 
            // listeDesÉquipesToolStripMenuItem
            // 
            this.listeDesÉquipesToolStripMenuItem.Name = "listeDesÉquipesToolStripMenuItem";
            this.listeDesÉquipesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listeDesÉquipesToolStripMenuItem.Text = "liste des équipes";
            this.listeDesÉquipesToolStripMenuItem.Click += new System.EventHandler(this.listeDesÉquipesToolStripMenuItem_Click);
            // 
            // ajoutÉquipeToolStripMenuItem
            // 
            this.ajoutÉquipeToolStripMenuItem.Name = "ajoutÉquipeToolStripMenuItem";
            this.ajoutÉquipeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ajoutÉquipeToolStripMenuItem.Text = "Ajout équipe";
            this.ajoutÉquipeToolStripMenuItem.Click += new System.EventHandler(this.ajoutÉquipeToolStripMenuItem_Click);
            // 
            // ajoutMembreToolStripMenuItem
            // 
            this.ajoutMembreToolStripMenuItem.Name = "ajoutMembreToolStripMenuItem";
            this.ajoutMembreToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ajoutMembreToolStripMenuItem.Text = "Ajout Membre";
            this.ajoutMembreToolStripMenuItem.Click += new System.EventHandler(this.ajoutMembreToolStripMenuItem_Click);
            // 
            // modifierÉquipeToolStripMenuItem
            // 
            this.modifierÉquipeToolStripMenuItem.Name = "modifierÉquipeToolStripMenuItem";
            this.modifierÉquipeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifierÉquipeToolStripMenuItem.Text = "Modifier équipe";
            this.modifierÉquipeToolStripMenuItem.Click += new System.EventHandler(this.modifierÉquipeToolStripMenuItem_Click);
            // 
            // modifierMembreToolStripMenuItem
            // 
            this.modifierMembreToolStripMenuItem.Name = "modifierMembreToolStripMenuItem";
            this.modifierMembreToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifierMembreToolStripMenuItem.Text = "Modifier membre";
            this.modifierMembreToolStripMenuItem.Click += new System.EventHandler(this.modifierMembreToolStripMenuItem_Click);
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.qUITTERToolStripMenuItem.Text = "quitter";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.QUITTERToolStripMenuItem_Click);
            // 
            // déconexionToolStripMenuItem
            // 
            this.déconexionToolStripMenuItem.Name = "déconexionToolStripMenuItem";
            this.déconexionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.déconexionToolStripMenuItem.Text = "déconexion";
            this.déconexionToolStripMenuItem.Click += new System.EventHandler(this.déconexionToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 28);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 423);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ajouterConférencierToolStripMenuItem
            // 
            this.ajouterConférencierToolStripMenuItem.Name = "ajouterConférencierToolStripMenuItem";
            this.ajouterConférencierToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ajouterConférencierToolStripMenuItem.Text = "Ajouter conférencier";
            this.ajouterConférencierToolStripMenuItem.Click += new System.EventHandler(this.ajouterConférencierToolStripMenuItem_Click);
            // 
            // nouvelleParticipationToolStripMenuItem
            // 
            this.nouvelleParticipationToolStripMenuItem.Name = "nouvelleParticipationToolStripMenuItem";
            this.nouvelleParticipationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nouvelleParticipationToolStripMenuItem.Text = "nouvelle participation";
            this.nouvelleParticipationToolStripMenuItem.Click += new System.EventHandler(this.nouvelleParticipationToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormMenu";
            this.Text = "HACKAT\'INNOV";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem hACKATHONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem déconexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterAtelierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterConférencierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleParticipationToolStripMenuItem;
    }
}