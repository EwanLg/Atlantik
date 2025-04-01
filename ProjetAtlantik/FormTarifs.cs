using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace ProjetAtlantik
{
    public partial class FormTarifs : Form
    {
        private MySqlConnection maCnx;
        public FormTarifs(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
            lbxTarifsSecteur.SelectedIndexChanged += lbxTarifsSecteur_SelectedIndexChanged;
        }
        private void FormTarifs_Load(object sender, EventArgs e)
        {
            if (maCnx.State == ConnectionState.Closed)
            {
                maCnx.Open();
            }

            try
            {
                ChargerSecteurs();
                if (lbxTarifsSecteur.Items.Count > 0)
                {
                    lbxTarifsSecteur.SelectedIndex = 0;
                    ChargerLiaisons(((Secteur)lbxTarifsSecteur.SelectedItem).GetNoSecteur());
                }
                ChargerPeriode();
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();

                string query = "SELECT * FROM type";
                int i = 1;
                Label lblTarifsTypeCategorieText = new Label();
                lblTarifsTypeCategorieText.Text = "Catégorie - Type";
                lblTarifsTypeCategorieText.Location = new Point(5, i * 25);
                gbxTarifsType.Controls.Add(lblTarifsTypeCategorieText);
                Label lblTarifsTypeCategorieText2 = new Label();
                lblTarifsTypeCategorieText2.Text = "Tarif";
                lblTarifsTypeCategorieText2.Location = new Point(125, i * 25);
                gbxTarifsType.Controls.Add(lblTarifsTypeCategorieText2);
                i++;
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                {
                    while (jeuEnr.Read())
                    {
                        Label lblTarifsTypeCategorie = new Label();
                        lblTarifsTypeCategorie.Text = jeuEnr["lettrecategorie"] +  jeuEnr["notype"].ToString() + " - " + jeuEnr["libelle"];
                        lblTarifsTypeCategorie.Location = new Point(5, i * 25);
                        gbxTarifsType.Controls.Add(lblTarifsTypeCategorie);

                        TextBox tbxTarifsTypeCategorie = new TextBox();
                        tbxTarifsTypeCategorie.Tag = jeuEnr["lettrecategorie"] + jeuEnr["notype"].ToString();
                        tbxTarifsTypeCategorie.Location = new Point(125, i * 25);
                        gbxTarifsType.Controls.Add(tbxTarifsTypeCategorie);
                        i++;
                    }
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

        private void ChargerSecteurs()
        {
            string query = "SELECT noSecteur, nom FROM secteur";

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
                        Secteur s = new Secteur(jeuEnr.GetString("nom"), jeuEnr.GetInt32("noSecteur"));
                        lbxTarifsSecteur.Items.Add(s);

                    }
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

        private void ChargerLiaisons(int noSecteur)
        {
            cmbTarifsLiaison.Items.Clear();
            cmbTarifsLiaison.Text = null;
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
                {
                    while (jeuEnr.Read())
                    {
                        hasResults = true;
                        i++;
                        string nomPortDepart = jeuEnr.GetString("nom_port_depart");
                        string nomPortArrivee = jeuEnr.GetString("nom_port_arrivee");
                        Liaison l = new Liaison(jeuEnr.GetInt32("noport_depart"), jeuEnr.GetInt32("noport_arrivee"), jeuEnr.GetInt32("nosecteur"), jeuEnr.GetInt32("noliaison"), nomPortDepart, nomPortArrivee);
                        cmbTarifsLiaison.Items.Add(l);
                    }
                    jeuEnr.Close();
                    if (!hasResults)
                    {
                        cmbTarifsLiaison.Items.Clear();
                        cmbTarifsLiaison.Text = "Aucune liaison pour ce secteur.";
                        cmbTarifsLiaison.Enabled = false;
                    }
                    else
                    {
                        cmbTarifsLiaison.Text = "Choisissez une liaison. (" + i + " liaison)";
                        cmbTarifsLiaison.Enabled = true;
                    }
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

        private void ChargerPeriode()
        {
            string query = "SELECT datedebut, datefin, noperiode FROM periode";

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
                        Periode pe = new Periode(jeuEnr.GetDateTime("datedebut"), jeuEnr.GetDateTime("datefin"), jeuEnr.GetInt32("noPeriode"));
                        cmbTarifsPeriode.Items.Add(pe);
                    }
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

        private void lbxTarifsSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTarifsSecteur.SelectedItem != null)
            {
                Secteur secteurSelectionne = (Secteur)lbxTarifsSecteur.SelectedItem;
                int noSecteur = secteurSelectionne.GetNoSecteur();
                ChargerLiaisons(noSecteur);
            }
        }

        private void cmbTarifsLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTarifsLiaison.SelectedItem != null && cmbTarifsLiaison.SelectedItem.ToString() == cmbTarifsLiaison.Tag?.ToString())
            {
                cmbTarifsLiaison.SelectedIndex = -1; 
            }
        }

        private void btnTarifsAjouter_Click(object sender, EventArgs e)
        {
            if (lbxTarifsSecteur.SelectedItem == null || cmbTarifsLiaison.SelectedItem == null || cmbTarifsPeriode.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un secteur, une liaison et une période.");
                return;
            }

            Periode periode = (Periode)cmbTarifsPeriode.SelectedItem;
            Liaison liaison = (Liaison)cmbTarifsLiaison.SelectedItem;

            bool tarifSaisi = false;
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control control in gbxTarifsType.Controls)
            {
                if (control is TextBox tbxTarif)
                {
                    textBoxes.Add(tbxTarif);
                }
            }

            foreach (TextBox tbxTarif in textBoxes)
            {
                if (!string.IsNullOrEmpty(tbxTarif.Text))
                {
                    tarifSaisi = true;
                    break;
                }
            }

            if (!tarifSaisi)
            {
                MessageBox.Show("Veuillez renseigner au moins un tarif.");
                return;
            }

            foreach (TextBox tbxTarif in textBoxes)
            {
                string lettreCategorie = tbxTarif.Tag.ToString().Substring(0, 1);
                string type = tbxTarif.Tag.ToString().Substring(1); 
                double tarif;

                if (double.TryParse(tbxTarif.Text, out tarif))
                {
                    string query = "INSERT INTO tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) " +
                                   "VALUES (@noperiode, @lettrecategorie, @notype, @noliaison, @tarif)";

                    try
                    {
                        if (maCnx.State == ConnectionState.Closed)
                            maCnx.Open();

                        MySqlCommand cmd = new MySqlCommand(query, maCnx);
                        {
                            cmd.Parameters.AddWithValue("@noperiode", periode.GetNoPeriode());
                            cmd.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                            cmd.Parameters.AddWithValue("@notype", type);
                            cmd.Parameters.AddWithValue("@noliaison", liaison.GetNoLiaison());
                            cmd.Parameters.AddWithValue("@tarif", tarif);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'ajout du tarif : {ex.Message} (Tarifs déjà existant");
                        return;
                    }
                    finally
                    {
                        if (maCnx.State == ConnectionState.Open)
                            maCnx.Close();
                    }
                }
            }
            MessageBox.Show("Tarifs ajoutés avec succès !");
        }
    }
}
