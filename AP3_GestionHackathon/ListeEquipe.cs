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
    public partial class ListeEquipe : Form
    {
        private int idEquipes;
        private int idEquipesH;
        private int idEquipesM;
        private int idMembre;
        private string Nom;
        private string prenom;
        private string Email;
        private string tel;
        private DateTime dateN;
        private string lien;
        private int cpt = 0;
        private int idHack;
        public ListeEquipe()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            BSequipe.DataSource = Modele.listeEquipe().Select(x => new { x.idequipe, x.nomequipe, x.nbparticipants, x.login })
               .OrderBy(x => x.nomequipe);

            dgvEquipe.DataSource = BSequipe;
            dgvEquipe.Columns["idequipe"].Visible = false;
            dgvEquipe.Columns[1].HeaderText = "Nom equipe";
            dgvEquipe.Columns[2].HeaderText = "nombre";

            BSmembre.DataSource = Modele.listeMembre().Select(x => new { x.idequipe, x.nom, x.prenom, x.idmembre, x.datenaissance, x.email, x.telephone, x.lienportfolio })
                .OrderBy(x => x.nom);
            dgvMembre.DataSource = BSmembre;
            dgvMembre.Columns["idmembre"].Visible = false;
            dgvMembre.Columns["idequipe"].Visible = false;
            dgvMembre.Columns["lienportfolio"].Visible = false;
            dgvMembre.Columns["datenaissance"].Visible = false;
            dgvMembre.Columns["email"].Visible = false;
            dgvMembre.Columns["telephone"].Visible = false;



            btAnnul.Visible = false;
            btSupEm.Visible = false;
            btSupMe.Visible = true;
            lMembre.Visible = true;
            dgvHack.Visible = false;
            btSupHack.Visible = false;
            lHack.Visible = false;
        }

        private void Equipe(int idequi)
        {
           int verif = Modele.listeMembre().Select(x => new { x.idequipe, x.nom, x.prenom, x.idmembre})
            .Where(x => x.idequipe == idequi).OrderBy(x => x.nom).Count();

            BSmembre.DataSource = Modele.listeMembre().Select (x => new { x.idequipe, x.nom, x.prenom, x.idmembre, x.datenaissance, x.email,x.telephone,x.lienportfolio })
            .Where(x => x.idequipe == idequi).OrderBy(x => x.nom);

            dgvMembre.DataSource = BSmembre;

            if (verif > 0)
            {
                dgvMembre.Columns["idmembre"].Visible = false;
                dgvMembre.Columns["idequipe"].Visible = false;
                dgvMembre.Columns["lienportfolio"].Visible = false;
                dgvMembre.Columns["datenaissance"].Visible = false;
                dgvMembre.Columns["email"].Visible = false;
                dgvMembre.Columns["telephone"].Visible = false;

            }
            btAnnul.Visible = true;
            btSupEm.Visible = true;
            btSupMe.Visible = false;
        }


        private void Hack(int idequi)
        {
            int verif = Modele.listeHack().Select(x => new { x.idequipe, x.hackathon.thematique, x.idhackathon, x.dateinscription })
               .Where(x => x.idequipe == idequi).OrderBy(x => x.dateinscription).Count();

            BShack.DataSource = Modele.listeHack().Select(x => new { x.idequipe, x.hackathon.thematique, x.idhackathon, x.dateinscription, x.Date_desinscription })
                .Where(x => x.idequipe == idequi && x.Date_desinscription == null ).OrderBy(x => x.dateinscription);
            dgvHack.DataSource = BShack;

            if (verif > 0)
            {
                dgvHack.Columns["idequipe"].Visible = false;
                dgvHack.Columns["idhackathon"].Visible = false;
                dgvHack.Columns["Date_desinscription"].Visible = false;
            }

            dgvHack.Visible = true;
            btSupHack.Visible = true;
            lHack.Visible = true;

        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEquipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Type type = BSequipe.Current.GetType();
            idEquipes = (int)type.GetProperty("idequipe").GetValue(BSequipe.Current, null);
            Equipe(idEquipes);
            Hack(idEquipes);
            cpt++;

        }

        private void btnSupEquipe_Click(object sender, EventArgs e)
        {

        }

        private void btAnnul_Click(object sender, EventArgs e)
        {
            refresh();
            cpt = 0;
        }

        private void dgvMembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Type type = BSmembre.Current.GetType();
            idEquipesM = (int)type.GetProperty("idequipe").GetValue(BSmembre.Current, null);
            idMembre = (int)type.GetProperty("idmembre").GetValue(BSmembre.Current, null); 
            Nom = (string)type.GetProperty("nom").GetValue(BSmembre.Current, null);
            prenom = (string)type.GetProperty("prenom").GetValue(BSmembre.Current, null);
            Email = (string)type.GetProperty("prenom").GetValue(BSmembre.Current, null);
            tel = (string)type.GetProperty("telephone").GetValue(BSmembre.Current, null);
            dateN = (DateTime)type.GetProperty("datenaissance").GetValue(BSmembre.Current, null);
            lien = (string)type.GetProperty("lienportfolio").GetValue(BSmembre.Current, null);
            if (cpt > 0)
            {
                btSupEm.Enabled = true;
            }

        }

        private void btSupMe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer le membre", "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modele.SupMembre(idMembre, idEquipesM);
                Modele.AjoutMembreLog(idMembre,Nom, prenom, Email, tel, idEquipesM, lien, dateN);
                refresh();
                cpt = 0;
            }
            else
            {
                MessageBox.Show("Action annulé");
            }

        }

        private void btSupEm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer le membre de l'équipe", "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modele.modifdeEquipe(idMembre, idEquipes);
                refresh();
                cpt = 0;
                btSupEm.Enabled = false;
            }
            else
            {
                MessageBox.Show("Operation annulé");
            }
        }

        private void dgvHack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Type type = BShack.Current.GetType();
            idEquipesH = (int)type.GetProperty("idequipe").GetValue(BShack.Current, null);
            idHack = (int)type.GetProperty("idhackathon").GetValue(BShack.Current, null);
            btSupHack.Enabled = true;

        }

        private void btSupHack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer l'équipe de cette hackathon", "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modele.SupInscriptionH(idHack, idEquipesH);
                refresh();
                btSupHack.Enabled = false;
                cpt = 0;
            }
            else
            {
                MessageBox.Show("Operation annulé");
            }
        }
        
        
    }
}
