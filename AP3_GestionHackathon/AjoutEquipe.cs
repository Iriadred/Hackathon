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
    public partial class AjoutEquipe : Form
    {
        private string Type;
        private int equipeO;
        private int id;
        private int idE;
        public AjoutEquipe(string type)
        {
            InitializeComponent();

            this.Type = type;
            if (type == "ajoutE")
            {
                gbAjout.Visible = true;
                txtPassword.PasswordChar = '*';
            }
            if (type == "ajoutM")
            {
                cbEquipe.ValueMember = "idequipe";//permet de stocker l'identifiant
                cbEquipe.DisplayMember = "nomequipe";
                BSequipe.DataSource = Modele.listeEquipe();
                cbEquipe.DataSource = BSequipe;
                cbEquipe.SelectedItem = -1;
                gbModifier.Visible = true;
                txtPassword.PasswordChar = '*';
            }
            if (type == "modifierE")
            {
                cbChoix.ValueMember = "idequipe";//permet de stocker l'identifiant
                cbChoix.DisplayMember = "nomequipe";
                cbChoix.SelectedIndex = -1;
                BSajout.DataSource = Modele.listeEquipe();
                cbChoix.DataSource = BSajout;
                BSequipe.DataSource = Modele.listeEquipe();
                cbEquipe.DataSource = BSequipe;
                cbChoix.SelectedIndex = -1;
                cbChoix.Enabled = true;
                txtPassword.PasswordChar = '*';
            }
            if (type == "modifierM")
            {
                RemplirListeMembre();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void RemplirListeMembre()
        {
            int p = cbEquipe.SelectedIndex;
            cbChoix.ValueMember = "idmembre";//permet de stocker l'identifiant
            cbChoix.DisplayMember = "nom";
            BSajout.DataSource = Modele.listeMembre();
            cbChoix.DataSource = BSajout;
            cbChoix.SelectedIndex = -1;

            cbEquipe.ValueMember = "idequipe";//permet de stocker l'identifiant
            cbEquipe.DisplayMember = "nomequipe";
            BSequipe.DataSource = Modele.listeEquipe();
            cbEquipe.DataSource = BSequipe;

            cbChoix.Enabled = true;
            txtPassword.PasswordChar = '*';
        }

        private void btAnnulM_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtNom.Text = "";
            txtPortfolio.Text = "";
            txtTel.Text = "";
            txtPrenom.Text = "";
            cbEquipe.SelectedIndex = -1;
            dtpNaiss.Value = DateTime.Now;
            txtPortfolio.Text = "";
        }



        private void btAjoutM_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPrenom.Text != "" && txtNom.Text != "" && dtpNaiss.Value < DateTime.Now)
            {
                int p = Convert.ToInt32(cbEquipe.SelectedValue);
                if (Type == "ajoutM")
                {
                    Modele.AjoutMembre(txtNom.Text, txtPrenom.Text, txtEmail.Text, txtTel.Text, p, txtPortfolio.Text, dtpNaiss.Value);
                }
                if (Type == "modifierM")
                {
                    if (equipeO == p)
                    {
                        Modele.modifMSans(id, txtNom.Text, txtPrenom.Text, txtTel.Text, txtEmail.Text, dtpNaiss.Value, txtPortfolio.Text);
                    }
                    else
                    {
                        Modele.modifMAvec(id, p, equipeO, txtNom.Text, txtPrenom.Text, txtTel.Text, txtEmail.Text, dtpNaiss.Value, txtPortfolio.Text) ;
                    }

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Champ incomplet");
            }
        }

        private void btAjoutE_Click(object sender, EventArgs e)
        {
            if(Type == "ajoutE")
            {
                Modele.AjoutEquipe(txtNomE.Text, txtLogin.Text, txtPassword.Text, txtLien.Text);
            }
            if(Type == "modifierE")
            {
                Modele.modifEquipe(idE,txtNomE.Text, txtLogin.Text, txtPassword.Text, txtLien.Text);
            }
            this.Close();

        }

        private void btAnnulerE_Click(object sender, EventArgs e)
        {
            txtNomE.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
        }
        private void BSListeM_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BSajout_CurrentItemChanged(object sender, EventArgs e)
        {
            int n = cbEquipe.SelectedIndex;
            int l = cbChoix.SelectedIndex;
            if (Type == "modifierM")
            {
                if (l != -1)
                {
                    // récupération de l'hackathon sélectionné
                    membre H = (membre)BSajout.Current;

                    // mise à jour des champs de l'hackathon sélectionné
                    txtNom.Text = H.nom;
                    txtPrenom.Text = H.prenom;
                    int p = -1;

                    if (H.telephone != null)
                    {
                        txtTel.Text = H.telephone;
                    }
                    txtEmail.Text = H.email;
                    if (H.datenaissance != null)
                    {
                        dtpNaiss.Value = (DateTime)H.datenaissance;
                    }
                    if (H.idequipe != null)
                    {
                         p = (int)H.idequipe;
                    }
                    if (cbEquipe.ValueMember == "idequipe")
                    {
                        cbEquipe.SelectedValue = p;
                        equipeO = p;
                    }
                    if (H.lienportfolio != null)
                    {
                        txtPortfolio.Text = H.lienportfolio;
                    }
                    id = H.idmembre;

                    gbModifier.Visible = true;
                }

                else
                    gbModifier.Visible = false;
            }
            if (l != -1)
            {
                if (Type == "modifierE")
                {
                    equipe E = (equipe)BSajout.Current;
                    txtNomE.Text = E.nomequipe;
                    txtLogin.Text = E.login;
                    if (E.lienprototype != null)
                    {
                        txtLien.Text = E.lienprototype;
                    }
                    gbAjout.Visible = true;
                    idE = E.idequipe;
                }
            }
            else
            {
                gbAjout.Visible = false;
            }
        }

        private void cbChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            BSajout_CurrentItemChanged(sender, e);
        }

        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPass.Checked == true)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
