using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace AP3_GestionHackathon
{
    public static class Modele
    {
        private static fantocheEntities maConnexion;
        private static hackathon hack;
        private static membre M;
        private static inscrire inscrit;
        private static ArchiveHackathon archiveHack;

        /// <summary>
        /// initialise la connexion à la BD
        /// </summary>
        public static void init()
        {
            maConnexion = new fantocheEntities();
            hackathon hack = new hackathon();
        }

        /// <summary>
        /// Retourne toute la liste des hackathons
        /// </summary>
        /// <returns></returns>
        public static List<hackathon> listeHackathons()
        {
            return maConnexion.hackathon.ToList();
        }

        public static List<atelier> listeAtelier()
        {
            return maConnexion.atelier.ToList();
        }
        public static List<organise> listeOrga()
        {
            return maConnexion.organise.ToList();
        }

        public static List<equipe> listeEquipe()
        {
            return maConnexion.equipe.ToList();
        }

        public static List<conferencier> listeConf()
        {
            return maConnexion.conferencier.ToList();
        }

        public static List<membre> listeMembre()
        {
            return maConnexion.membre.ToList();
        }

        public static List<inscrire> listeHack()
        {
            return maConnexion.inscrire.ToList();
        }

        /// <summary>
        /// Retourne toute la liste des organisateurs
        /// </summary>
        /// <returns></returns>
        public static List<organisateur> listeOrganisateurs()
        {
            return maConnexion.organisateur.ToList();
        }

        public static List<salle> listeSalle()
        {
            return maConnexion.salle.ToList();
        }

        /// <summary>
        /// Retourne la liste des équipes inscrites à l'hackathon dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idH"></param>
        /// <returns></returns>
        public static List<equipe> listeEquipesParHackathon(int idH)
        {
            // parcourir les équipes et récupérer celle de l'hackathon
            hackathon h = maConnexion.hackathon.Find(idH);
            List<inscrire> lesI = h.inscrire.ToList();
            List<equipe> lesE = new List<equipe>();
            foreach (inscrire I in lesI)
            {
                lesE.Add(I.equipe);
            }
            return lesE;
        }

        /// <summary>
        /// Retourne l'identifiant du dernier hackathon saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierHackathonSaisi()
        {
            return maConnexion.hackathon.Max(x => x.idhackathon);
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'un hackathon a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <returns></returns>
        public static bool AjoutHackathon(string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int nb_equipe, DateTime dateI)
        {
            hackathon unHackathon;
            bool vretour = true;
            try
            {
                // ajout dans la table commande

                unHackathon = new hackathon();
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nb_equipe = nb_equipe;
                unHackathon.date_fin_incrip = dateI;

                maConnexion.hackathon.Add(unHackathon);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static int AjoutAtelier(string Nom,  DateTime dateD, DateTime dateF, int idSalle, int nbPlace)
        {
             atelier UnAtelier;
            int id = 0;
            try
            {
                // ajout dans la table commande

                UnAtelier = new atelier();
                UnAtelier.datedebut = dateD;
                UnAtelier.datefin = dateF;
                UnAtelier.id_salle = idSalle;
                UnAtelier.nom_atelier = Nom;
                UnAtelier.nbPlace = nbPlace;


                maConnexion.atelier.Add(UnAtelier);
                maConnexion.SaveChanges();
                id = UnAtelier.id_atelier;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return id;
        }
        public static bool AjoutAdministrateur(string nom, string prenom, string email)
        {
            administrateur unAdmin;
            bool vretour = true;
            try
            {
                // ajout dans la table o
                unAdmin = new administrateur();
                unAdmin.nom = nom;
                unAdmin.prenom = prenom;
                unAdmin.email = email;

                maConnexion.administrateur.Add(unAdmin);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        /// <summary>
        /// Fonction qui retourne l'objet hackathon qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idH">identifiant de l'hackathon</param>
        /// <returns></returns>
        public static hackathon RecupererHackathon(int idH)
        {
            hackathon unHackathon = new hackathon();
            try
            {
                unHackathon = maConnexion.hackathon.First(x => x.idhackathon == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unHackathon;
        }

        /// <summary>
        /// Retourne vrai si la modification de l'hackathon dont l'identifiant est passé en paramètre a pu avoir lieu
        /// </summary>
        /// <param name="idH"></param>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <returns></returns>
        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int nb_equipe, DateTime dateI)
        {
            hackathon unHackathon;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unHackathon = RecupererHackathon(idH);

                // mise à jour des champs de l'hackathon
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nb_equipe = nb_equipe;
                unHackathon.date_fin_incrip = dateI;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }


        /// <summary>
        /// Retourne vrai si l'ajout d'un organisateur a pu avoir lieu
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool AjoutOrganisateur(string nom, string prenom, string email)
        {
            organisateur unOrga;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unOrga = new organisateur();
                unOrga.nom = nom;
                unOrga.prenom = prenom;
                unOrga.email = email;

                maConnexion.organisateur.Add(unOrga);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        //fonction connexion admin
        public static bool connexionadmin(string login, string mdp)
        {
            bool connreturn = false;
            administrateur adm = new administrateur();

            try
            {
                connreturn = false;

                adm = maConnexion.administrateur.First(x => x.prenom == login);

                string passwordbase = adm.motpasse;
                bool verified = BCrypt.Net.BCrypt.Verify(mdp, passwordbase);

                if (verified)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Mots de passe incorrect");
                    return false;
                }


            }
            catch (Exception e)
            {
                connreturn = false;
                MessageBox.Show("identifiant incorrect");
            }
            return connreturn;
        }

        public static hackathon RecupererHack(int idhack)
        {
            hackathon hack = new hackathon();
            try
            {
                hack = maConnexion.hackathon.First(x => x.idhackathon == idhack);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return hack;
        }
        public static bool SupHack(int idHack)
        {
            bool vretour = true;
            try
            {
                hack = RecupererHack(idHack);
                maConnexion.hackathon.Remove(hack);
                maConnexion.SaveChanges();
                MessageBox.Show("donné supprimer");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }

        public static bool SupMembre(int idMembre, int idEquipe)
        {
            bool vretour = true;
            try
            {
                MoinNb(idEquipe);
                M = RecupererMembre(idMembre);
                maConnexion.membre.Remove(M);
                maConnexion.SaveChanges();
                MessageBox.Show("donné supprimer");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }

        public static bool SupInscriptionH(int idHack, int idEquipe)
        {
            bool vretour = true;
            try
            {
                inscrit = RecupererInscription(idHack, idEquipe);
                inscrit.Date_desinscription = DateTime.Now;
                maConnexion.SaveChanges();
                MessageBox.Show("donné supprimer");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }



        public static void RecupererNb(int ideq)
        {
            equipe eq = new equipe();
            int nb = 0;
            try
            {
                eq = maConnexion.equipe.First(x => x.idequipe == ideq);
                nb = (int)eq.nbparticipants;
                nb++;
                modifNbMembre(ideq, nb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public static bool AjoutAchiveHack(int idHack, DateTime dateD, DateTime dateF, DateTime dateI, string lieu, string ville
            , string condition, string thematique, string affiche, string objectifs, int idorganisateur, decimal nb_equipe)
        {
            bool vretour = true;
            try
            {

                archiveHack = new ArchiveHackathon();
                archiveHack.idhackathon = idHack; // mise à jour des propriétés
                archiveHack.dateheuredebuth = dateD.Date;
                archiveHack.dateheurefinh = dateF.Date;
                archiveHack.lieu = lieu;
                archiveHack.date_fin_incrip = dateI.Date;
                archiveHack.ville = ville;
                archiveHack.conditions = condition;
                archiveHack.thematique = thematique;
                archiveHack.affiche = affiche;
                archiveHack.objectifs = objectifs;
                archiveHack.idorganisateur = idorganisateur;
                archiveHack.nb_equipe = nb_equipe;

                maConnexion.ArchiveHackathon.Add(archiveHack); // ajout de l’objet
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static bool AjoutMembre(string Nom, string prenom, string email, string tel, int idequipe, string lien, DateTime date)
        {
            membre unMembre;
            bool vretour = true;
            try
            {
                // ajout dans la table commande

                RecupererNb(idequipe);

                unMembre = new membre();
                unMembre.idequipe = idequipe;
                unMembre.nom = Nom;
                unMembre.prenom = prenom;
                unMembre.email = email;
                unMembre.telephone = tel;
                unMembre.lienportfolio = lien;
                unMembre.datenaissance = date;


                maConnexion.membre.Add(unMembre);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutMembreLog(int idMembre,string Nom, string prenom, string email, string tel,int idequipe,  string lien, DateTime date)
        {
            ArchiveMembre unMembre;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                
                unMembre = new ArchiveMembre();
                unMembre.idmembre = idMembre;
                unMembre.idequipe = idequipe;
                unMembre.nom = Nom;
                unMembre.prenom = prenom;
                unMembre.email = email;
                unMembre.telephone = tel;
                unMembre.lienportfolio = lien;
                unMembre.datenaissance = date;


                maConnexion.ArchiveMembre.Add(unMembre);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutEquipe(string Nom, string login, string mdp, string lien)
        {
            equipe uneEquipe;
            bool vretour = true;
            try
            {
                // ajout dans la table commande

                uneEquipe = new equipe();
                uneEquipe.nomequipe = Nom;
                uneEquipe.login = login;
                uneEquipe.password = BCrypt.Net.BCrypt.HashPassword(mdp);
                uneEquipe.nbparticipants = 0;
                uneEquipe.lienprototype = lien;


                maConnexion.equipe.Add(uneEquipe);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        public static bool modifNbMembre(int idH, int nb)
        {
            equipe uneEqquipe;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneEqquipe = RecupererEquipe(idH);

                // mise à jour des champs de l'hackathon
                uneEqquipe.nbparticipants = nb;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        public static equipe RecupererEquipe(int idH)
        {
            equipe uneequipe = new equipe();
            try
            {
                uneequipe = maConnexion.equipe.First(x => x.idequipe == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneequipe;
        }
        public static membre RecupererMembre(int idH)
        {
            membre unMembre = new membre();
            try
            {
                unMembre = maConnexion.membre.First(x => x.idmembre == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }

        public static 
            atelier lastID()
        {
            atelier unMembre = new atelier();
            try
            {
                unMembre = maConnexion.atelier.Last(x => x.nom_atelier == "a");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }

        public static bool AjoutOrganise(int idHack, int idA)
        {
            organise uneOrga;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneOrga = new organise();
                uneOrga.id_atelier = idA;
                uneOrga.id_hack = idHack;


                maConnexion.organise.Add(uneOrga);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutSalle(string Nom)
        {
            salle uneSalle;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneSalle = new salle();
                uneSalle.nom_salle = Nom;


                maConnexion.salle.Add(uneSalle);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutConf(string Nom,string Prenom)
        {
            conferencier uneConf;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneConf = new conferencier();
                uneConf.nom = Nom;
                uneConf.prenom = Prenom;


                maConnexion.conferencier.Add(uneConf);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ajoutLien(int idA, int idC)
        {
            participer uneParti;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneParti = new participer();
                uneParti.id_activite = idA;
                uneParti.id_conferencier = idC;


                maConnexion.participer.Add(uneParti);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }


        public static inscrire RecupererInscription(int idH,int idE)
        {
            inscrire unMembre = new inscrire();
            try
            {
                unMembre = maConnexion.inscrire.First(x => x.idequipe == idE && x.idhackathon == idH );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }

        public static bool modifMSans(int idH, string nom, string prenom, string tel, string email, DateTime date, string lien)
        {
            membre unMembre;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unMembre = RecupererMembre(idH);

                // mise à jour des champs de l'hackathon
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.telephone = tel;
                unMembre.email = email;
                unMembre.datenaissance = date;
                unMembre.lienportfolio = lien;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        public static bool modifMAvec(int idH, int NewIdEquipe, int LastIdEquipe, string nom, string prenom, string tel, string email, DateTime date, string lien)
        {
            membre unMembre;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unMembre = RecupererMembre(idH);
                MoinNb(LastIdEquipe);
                RecupererNb(NewIdEquipe);

                // mise à jour des champs de l'hackathon
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.telephone = tel;
                unMembre.email = email;
                unMembre.idequipe = NewIdEquipe;
                unMembre.datenaissance = date;
                unMembre.lienportfolio = lien;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool modifdeEquipe(int idM, int LastIdEquipe)
        {
            membre unMembre;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unMembre = RecupererMembre(idM);
                MoinNb(LastIdEquipe);

                // mise à jour des champs de l'hackathon
                unMembre.idequipe = null;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        public static void MoinNb(int ideq)
        {
            equipe eq = new equipe();
            int nb = 0;
            try
            {
                eq = maConnexion.equipe.First(x => x.idequipe == ideq);
                nb = (int)eq.nbparticipants;
                nb--;
                modifNbMembre(ideq, nb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public static bool modifEquipe(int idE ,string Nom, string login, string mdp, string lien)
        {
            equipe uneEquipe;
            bool vretour = true;
            try
            {

                // mise à jour des champs de l'hackathon
                uneEquipe = RecupererEquipe(idE);
                uneEquipe.nomequipe = Nom;
                uneEquipe.login = login;
                uneEquipe.password = BCrypt.Net.BCrypt.HashPassword(mdp);
                uneEquipe.lienprototype = lien;
                

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
    }
}
