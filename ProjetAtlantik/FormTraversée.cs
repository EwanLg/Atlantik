using MySql.Data.MySqlClient;
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
    public partial class FormTraversée : Form
    {
        private MySqlConnection maCnx;
        public FormTraversée(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
            lbxSecteurTraversée.SelectedIndexChanged += lbxSecteurTraversée_SelectedIndexChanged;
        }
        private void FormTraversée_Load(object sender, EventArgs e)
        {
            ChargerSecteurs();
            ChargerNomBateau();
            dtpTraverséeDépartJour.CustomFormat = "MM/dd/yyyy";
            dtpTraverséeDépartJour.Format = DateTimePickerFormat.Custom;
            dtpTraverséeDépartHeure.CustomFormat = "HH:mm";
            dtpTraverséeDépartHeure.Format = DateTimePickerFormat.Custom;
            dtpTraverséeDépartHeure.ShowUpDown = true;
            dtpTraverséeArrivéeJour.CustomFormat = "MM/dd/yyyy";
            dtpTraverséeArrivéeJour.Format = DateTimePickerFormat.Custom;
            dtpTraverséeArrivéeHeure.CustomFormat = "HH:mm";
            dtpTraverséeArrivéeHeure.Format = DateTimePickerFormat.Custom;
            dtpTraverséeArrivéeHeure.ShowUpDown = true;
            if (lbxSecteurTraversée.Items.Count > 0) 
            {
                lbxSecteurTraversée.SelectedIndex = 0;
                ChargerLiaisons(((Secteur)lbxSecteurTraversée.SelectedItem).GetNoSecteur());
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
                        lbxSecteurTraversée.Items.Add(s);
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
            cmbLiaisonTraversée.Items.Clear();
            cmbLiaisonTraversée.Text = null;
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
                        cmbLiaisonTraversée.Items.Add(l);
                    }
                    jeuEnr.Close();
                if (!hasResults)
                {
                    cmbLiaisonTraversée.Items.Clear();
                    cmbLiaisonTraversée.Text = "Aucune liaison pour ce secteur."; 
                    cmbLiaisonTraversée.Enabled = false; 
                }
                else
                {
                    cmbLiaisonTraversée.Text = i + " liaisons disponibles.";
                    cmbLiaisonTraversée.Enabled = true;
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
        private void ChargerNomBateau()
        {
            int i = 0;
            string query = "SELECT * FROM bateau";
            if (maCnx.State == ConnectionState.Closed)
            {
                maCnx.Open();
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                {
                    while (jeuEnr.Read())
                    {
                        Bateau b = new Bateau(jeuEnr.GetString("nom"), jeuEnr.GetInt32("nobateau"));
                        cmbNomBateauTraversée.Items.Add(b);
                        i++;
                    }
                    cmbNomBateauTraversée.Text = "Choisissez un bateau. (" + i + ")";
                    jeuEnr.Close();
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

        private void lbxSecteurTraversée_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSecteurTraversée.SelectedItem != null)
            {
                Secteur secteurSelectionne = (Secteur)lbxSecteurTraversée.SelectedItem;
                int noSecteur = secteurSelectionne.GetNoSecteur();
                ChargerLiaisons(noSecteur);
            }
        }

        private void btnAjouterTraversée_Click(object sender, EventArgs e)
        {
            if (cmbLiaisonTraversée.SelectedItem == null || cmbNomBateauTraversée.SelectedItem == null || lbxSecteurTraversée.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une liaison, un bateau et un secteur.");
                return;
            }

            Liaison l = (Liaison)cmbLiaisonTraversée.SelectedItem;
            Bateau b = (Bateau)cmbNomBateauTraversée.SelectedItem;
            Secteur secteur = (Secteur)lbxSecteurTraversée.SelectedItem;

            string query = "INSERT INTO traversee (NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) " +
                           "VALUES (@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee)";
            try
            {
                if (maCnx.State == System.Data.ConnectionState.Closed)
                    maCnx.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@noliaison", l.GetNoLiaison());
                    cmd.Parameters.AddWithValue("@nobateau", b.GetNoBateau());
                    cmd.Parameters.AddWithValue("@dateheuredepart", dtpTraverséeDépartJour.Value.Date.Add(dtpTraverséeDépartHeure.Value.TimeOfDay).AddSeconds(-dtpTraverséeDépartHeure.Value.Second));
                    cmd.Parameters.AddWithValue("@dateheurearrivee", dtpTraverséeArrivéeJour.Value.Date.Add(dtpTraverséeArrivéeHeure.Value.TimeOfDay).AddSeconds(-dtpTraverséeDépartHeure.Value.Second));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Traversée ajoutée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la traversée : {ex.Message}");
            }
            finally
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                    maCnx.Close();
            }
        }
    }
}
