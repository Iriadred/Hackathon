using System;
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
    public partial class ajoutConf : Form
    {
        private string Type;
        public ajoutConf(string type)
        {
            InitializeComponent();
            this.Type = type;
            if (Type == "Lien")
            {
                gbSalle.Visible = true;
            }
            if(type == "ajout")
            {

                cbConf.ValueMember = "id_conferencier";//permet de stocker l'identifiant
                cbConf.DisplayMember = "nom";
                BSconf.DataSource = Modele.listeConf();
                cbConf.DataSource = BSconf;
                cbConf.SelectedItem = -1;

                cbHack.ValueMember = "id_atelier";//permet de stocker l'identifiant
                cbHack.DisplayMember = "nom_atelier";
                BSatelier.DataSource = Modele.listeAtelier();
                cbHack.DataSource = BSatelier;
                cbHack.SelectedItem = -1;

                gbParti.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modele.AjoutConf(txtNom.Text, txtPrenom.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idA = Convert.ToInt32(cbHack.SelectedValue.ToString());
            int idC = Convert.ToInt32(cbConf.SelectedValue.ToString());

            Modele.ajoutLien(idA, idC);
            this.Close();
        }
    }
}
