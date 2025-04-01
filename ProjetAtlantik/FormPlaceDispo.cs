using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAtlantik
{
    public partial class FormPlaceDispo : Form
    {
        private MySqlConnection maCnx;
        public FormPlaceDispo(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
            lbxPlaceDispoSecteur.SelectedIndexChanged += lbxPlaceDispoSecteur_SelectedIndexChanged;
        }

        private void FormPlaceDispo_Load(object sender, EventArgs e)
        {
            ChargerSecteurs();
            dtpPlaceDispo.CustomFormat = "MM/dd/yyyy";
            dtpPlaceDispo.Format = DateTimePickerFormat.Custom;
            lvPlaceDispo.View = View.Details;
            lvPlaceDispo.Columns.Add("No traversée", 100);
            lvPlaceDispo.Columns.Add("Heure", 100);
            lvPlaceDispo.Columns.Add("Bateau", 100);
            lvPlaceDispo.Columns.Add("A passager", 100);
            lvPlaceDispo.Columns.Add("B véh.inf.2m", 100);
            lvPlaceDispo.Columns.Add("C véh.sup.2m", 100);
            if (lbxPlaceDispoSecteur.Items.Count > 0)
            {
                lbxPlaceDispoSecteur.SelectedIndex = 0;
                ChargerLiaisons(((Secteur)lbxPlaceDispoSecteur.SelectedItem).GetNoSecteur());
            }
        }
        private void ChargerSecteurs()
        {
            string query = "SELECT noSecteur, nom FROM secteur";
            try
            {
                if (maCnx.State == System.Data.ConnectionState.Closed)
                    maCnx.Open();

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                {
                    while (jeuEnr.Read())
                    {
                        Secteur s = new Secteur(jeuEnr.GetString("nom"), jeuEnr.GetInt32("noSecteur"));
                        lbxPlaceDispoSecteur.Items.Add(s);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion ou de lecture des secteurs : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                    maCnx.Close();
            }
        }
        private void ChargerLiaisons(int noSecteur)
        {
            cmbPlaceDispoLiaison.Items.Clear();
            cmbPlaceDispoLiaison.Text = null;
            int i = 0;

            string query = @"SELECT l.noliaison, l.noport_depart, l.nosecteur, l.noport_arrivee, 
                        p1.nom AS nom_port_depart, p2.nom AS nom_port_arrivee 
                 FROM liaison l 
                 INNER JOIN port p1 ON l.noport_depart = p1.noport 
                 INNER JOIN port p2 ON l.noport_arrivee = p2.noport
                 WHERE l.nosecteur = @noSecteur";
            if (maCnx.State == ConnectionState.Closed)
            {
                maCnx.Open();
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@noSecteur", noSecteur);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                bool hasResults = false;
                while (jeuEnr.Read())
                {
                    hasResults = true;
                    i++;
                    string nomPortDepart = jeuEnr.GetString("nom_port_depart");
                    string nomPortArrivee = jeuEnr.GetString("nom_port_arrivee");
                    Liaison l = new Liaison(jeuEnr.GetInt32("noport_depart"), jeuEnr.GetInt32("noport_arrivee"), jeuEnr.GetInt32("nosecteur"), jeuEnr.GetInt32("noliaison"), nomPortDepart, nomPortArrivee);
                    cmbPlaceDispoLiaison.Items.Add(l);
                }
                jeuEnr.Close();
                if (!hasResults)
                {
                    cmbPlaceDispoLiaison.Items.Clear();
                    cmbPlaceDispoLiaison.Text = "Aucune liaison pour ce secteur.";
                    cmbPlaceDispoLiaison.Enabled = false;
                }
                else
                {
                    cmbPlaceDispoLiaison.Text = i + " liaisons disponibles.";
                    cmbPlaceDispoLiaison.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        private void ChargerPlaceDispo()
        {
            string query = @"SELECT notraversee FROM traversee";

            try
            {
                lvPlaceDispo.Items.Clear();

                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();

                if (!jeuEnr.HasRows)
                {
                    MessageBox.Show("Aucune réservation trouvée pour ce client.");
                    return;
                }

                while (jeuEnr.Read())
                {
                    var tabItem = new string[6]
                    {
                        jeuEnr.GetInt32("NORESERVATION").ToString(),
                        jeuEnr.GetString(""),
                        jeuEnr.GetInt32("g").ToString(),
                        jeuEnr.GetDateTime("DATEHEUREDEPART").ToString("dd/MM/yyyy HH:mm"),
                        jeuEnr.GetDateTime("DATEHEUREDEPART").ToString("dd/MM/yyyy HH:mm"),
                        jeuEnr.GetDateTime("DATEHEUREDEPART").ToString("dd/MM/yyyy HH:mm")
                    };

                    ListViewItem item = new ListViewItem(tabItem);
                    item.Tag = tabItem[0];
                    lvPlaceDispo.Items.Add(item);
                }
                jeuEnr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargements des réservations : " + ex.Message);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        private List<Categorie> getLesCategories()
        {
            List<Categorie> categories = new List<Categorie>();
            string query = "SELECT LETTRECATEGORIE, LIBELLE FROM categorie";
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                while (jeuEnr.Read())
                {
                    categories.Add(new Categorie(jeuEnr.GetString("LETTRECATEGORIE"), jeuEnr.GetString("LIBELLE")));
                }
                jeuEnr.Close();
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
            return categories;
        }

        private List<Traversee> getLesTraverseesBateaux(int noLiaison, DateTime dateSelectionnee)
        {
            List<Traversee> traversees = new List<Traversee>();
            string query = @"SELECT t.NOTRAVERSEE, t.DATEHEUREDEPART, b.NOM AS NOM_BATEAU
                     FROM traversee t
                     JOIN bateau b ON t.NOBATEAU = b.NOBATEAU
                     WHERE t.NOLIAISON = @noLiaison AND DATE(t.DATEHEUREDEPART) = @dateSelectionnee
                     ORDER BY t.DATEHEUREDEPART";
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@noLiaison", noLiaison);
                cmd.Parameters.AddWithValue("@dateSelectionnee", dateSelectionnee);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                while (jeuEnr.Read())
                {
                    traversees.Add(new Traversee(
                        jeuEnr.GetInt32("NOTRAVERSEE"),
                        jeuEnr.GetDateTime("DATEHEUREDEPART"),
                        jeuEnr.GetString("NOM_BATEAU")
                    ));
                }
                jeuEnr.Close();
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
            return traversees;
        }

        private int getQuantiteEnregistree(int noTraversee, string lettreCategorie)
        {
            string query = "SELECT IFNULL(SUM(QUANTITERESERVEE), 0) AS Quantite FROM enregistrer WHERE NOTRAVERSEE = @noTraversee AND LETTRECATEGORIE = @lettreCategorie";
            int quantite = 0;
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@noTraversee", noTraversee);
                cmd.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                quantite = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
            return quantite;
        }

        private int getCapaciteMaximale(int noTraversee, string lettreCategorie)
        {
            string query = "SELECT CAPACITEMAX FROM contenir JOIN traversee USING (NOBATEAU) WHERE NOTRAVERSEE = @noTraversee AND LETTRECATEGORIE = @lettreCategorie";
            int capacite = 0;
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@noTraversee", noTraversee);
                cmd.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                capacite = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
            return capacite;
        }

        private void lbxPlaceDispoSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPlaceDispoSecteur.SelectedItem != null)
            {
                Secteur secteurSelectionne = (Secteur)lbxPlaceDispoSecteur.SelectedItem;
                int noSecteur = secteurSelectionne.GetNoSecteur();
                ChargerLiaisons(noSecteur);
            }
        }
        private void btnPlaceDispoAfficher_Click(object sender, EventArgs e)
        {
            ChargerPlaceDispo();
        }
    }
}
