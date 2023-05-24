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
    public partial class FormHackathon : Form
    {
        private int idHack;
        private DateTime DateD;
        private DateTime DateF;
        private DateTime DateI;
        private string lieu;
        private string ville;
        private string conditions;
        private string thematique;
        private string affiche;
        private string objectifs;
        private int idorganisateur;
        private decimal nb_equipe;

        public FormHackathon()
        {
            InitializeComponent();
            dgvAtelier.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoirLesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            int idH = (int)type.GetProperty("idhackathon").GetValue(BSHackathon.Current, null);
            List<equipe> lesEquipes = Modele.listeEquipesParHackathon(idH);
            if (lesEquipes.Count != 0)
            {
                BSEquipe.DataSource = (lesEquipes).Select(x => new
                {
                    x.idequipe,
                    x.nomequipe,
                    x.nbparticipants
                });

                dgvAtelier.DataSource = BSEquipe;
                dgvAtelier.Visible = true;
            }
            else
            {
                dgvAtelier.Visible = false;
                MessageBox.Show("Pas d'équipe pour cet hackathon");
            }
        }

        private void DgvHackathon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            idHack = (int)type.GetProperty("idhackathon").GetValue(BSHackathon.Current, null);
            DateD = (DateTime)type.GetProperty("dateheuredebuth").GetValue(BSHackathon.Current, null);
            DateF = (DateTime)type.GetProperty("dateheurefinh").GetValue(BSHackathon.Current, null);
            DateI = (DateTime)type.GetProperty("date_fin_incrip").GetValue(BSHackathon.Current, null);
            lieu = (string)type.GetProperty("lieu").GetValue(BSHackathon.Current, null);
            ville = (string)type.GetProperty("ville").GetValue(BSHackathon.Current, null);
            conditions = (string)type.GetProperty("conditions").GetValue(BSHackathon.Current, null);
            thematique = (string)type.GetProperty("thematique").GetValue(BSHackathon.Current, null);
            affiche = (string)type.GetProperty("affiche").GetValue(BSHackathon.Current, null);
            objectifs = (string)type.GetProperty("objectifs").GetValue(BSHackathon.Current, null);
            idorganisateur = (int)type.GetProperty("idorganisateur").GetValue(BSHackathon.Current, null);
            nb_equipe = (decimal)type.GetProperty("nb_equipe").GetValue(BSHackathon.Current, null);

            atelier(idHack);

            bSup.Enabled = true;
        }

        private void DgvHackathon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAtelier.Visible = false;
        }

        private void DgvHackathon_Click(object sender, EventArgs e)
        {
            dgvAtelier.Visible = false;
        }

        private void BSHackathon_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bSup_Click(object sender, EventArgs e)
        {
            Modele.SupHack(idHack);
            Modele.AjoutAchiveHack(idHack, DateD, DateF, DateI,lieu,ville,conditions,thematique,affiche,objectifs,idorganisateur,nb_equipe);
            MessageBox.Show("c bon");
            refresh();
        }

        private void atelier(int idH)
        {
            int verif = Modele.listeOrga().Select(x => new { x.atelier.nom_atelier, x.atelier.datedebut, x.atelier.datefin, x.atelier.salle.nom_salle, x.id_hack })
                           .Where(x => x.id_hack == idH).OrderBy(x => x.nom_atelier).Count();

            BSAtelier.DataSource = Modele.listeOrga().Select(x => new { x.atelier.nom_atelier, x.atelier.datedebut, x.atelier.datefin, x.atelier.salle.nom_salle, x.id_hack })
                           .Where(x => x.id_hack == idH) .OrderBy(x => x.nom_atelier);
            dgvAtelier.DataSource = BSAtelier;
            if (verif > 0)
            {
                dgvAtelier.Columns["id_hack"].Visible = false;
            }
            dgvAtelier.Visible = true;

        }
        private void refresh()
        {
            BSHackathon.DataSource = Modele.listeHackathons().Select(x => new { x.idhackathon, x.thematique, x.lieu, x.ville, x.dateheuredebuth, x.dateheurefinh, x.conditions, x.objectifs, x.affiche, x.idorganisateur,x.organisateur.nom, x.organisateur.prenom, x.nb_equipe, x.date_fin_incrip })
                           .OrderBy(x => x.dateheuredebuth);

            dgvHackathon.DataSource = BSHackathon;
            dgvHackathon.Columns["idhackathon"].Visible = false;
            dgvHackathon.Columns["conditions"].Visible = false;
            dgvHackathon.Columns["affiche"].Visible = false;
            dgvHackathon.Columns["idorganisateur"].Visible = false;
            dgvHackathon.Columns[1].HeaderText = "Thématique";
            dgvHackathon.Columns[2].HeaderText = "Lieu";
            dgvHackathon.Columns[3].HeaderText = "Ville";
            dgvHackathon.Columns[4].HeaderText = "Date de début";
            dgvHackathon.Columns[5].HeaderText = "Date de fin";
            dgvHackathon.Columns[7].HeaderText = "Objectifs";
            dgvHackathon.Columns[10].HeaderText = "Nom Organisateur";
            dgvHackathon.Columns[11].HeaderText = "Prénom Organisateur";
            dgvHackathon.Columns[12].HeaderText = "Nombre d'équipe maximal";
            dgvHackathon.Columns[13].HeaderText = "date de fin d'inscription";
            dgvAtelier.Visible = false;

        }

        private void dgvEquipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
