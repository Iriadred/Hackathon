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
    public partial class ajoutAtelier : Form
    {
        public ajoutAtelier()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            BSatelier.DataSource = Modele.listeSalle();
            cbAtelier.DataSource = BSatelier;
            cbAtelier.SelectedIndex = -1;
            cbAtelier.ValueMember = "id_salle";//permet de stocker l'identifiant
            cbAtelier.DisplayMember = "nom_salle";

            BShack.DataSource = Modele.listeHackathons();
            cbHack.DataSource = BShack;
            cbHack.SelectedIndex = -1;
            cbHack.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbHack.DisplayMember = "thematique";

        }

        private void btAnnul_Click(object sender, EventArgs e)
        {

        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            if(TxtAtelier.Text !="" && UDnb.Value > 0 && dtpDebut.Value> DateTime.Now && dtpFin.Value>dtpDebut.Value)
            {
                int a = Convert.ToInt32(UDnb.Value);
                int idSalle = Convert.ToInt32(cbAtelier.SelectedValue.ToString());
                int idHack = Convert.ToInt32(cbHack.SelectedValue.ToString());
                int id;
                //
                id = Modele.AjoutAtelier(TxtAtelier.Text, dtpDebut.Value, dtpFin.Value, idSalle, a);
                Modele.AjoutOrganise(idHack,id);
                this.Close();

            }
            else
            {
                MessageBox.Show("Erreur champ incorrect");
            }
        }

        private void cbAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbSalle.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSalle.Text != "")
            {
                Modele.AjoutSalle(txtSalle.Text);
                gbSalle.Visible = false;
                refresh();
            }
            else
            {
                MessageBox.Show("Champ non remplie");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSalle.Text = "";
            gbSalle.Visible = false;
        }
    }
}
