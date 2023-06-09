﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_GestionHackathon
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void QUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListeDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHackathon());
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void GestionDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void eQUIPEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hACKATHONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void déconexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Gestion = new Form1();
            Gestion.Show();
            this.Hide();
        }

        private void listeDesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ListeEquipe());
        }

        private void ajoutÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AjoutEquipe("ajoutE"));
        }

        private void ajoutMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AjoutEquipe("ajoutM"));
        }

        private void modifierÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AjoutEquipe("modifierE"));
        }

        private void modifierMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AjoutEquipe("modifierM"));
        }

        private void ajouterAtelierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ajoutAtelier());
        }

        private void nouvelleParticipationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ajoutConf("Lien"));
        }

        private void ajouterConférencierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ajoutConf("ajout"));
        }
    }
}
