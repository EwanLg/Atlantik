using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormLiaison : Form
    {
        private MySqlConnection maCnx;

        public FormLiaison(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
        }
        private void FormLiaison_Load(object sender, EventArgs e)
        {
            ChargerSecteurs();
            ChargerPorts();
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
                        lbxLiaisonSecteur.Items.Add(s);
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

        private void ChargerPorts()
        {
            string query = "SELECT noPort, nom FROM port";
            try
            {
                if (maCnx.State == System.Data.ConnectionState.Closed)
                    maCnx.Open();

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                {
                    while (jeuEnr.Read())
                    {
                        Port p = new Port(jeuEnr.GetString("nom"), jeuEnr.GetInt32("noPort"));
                        cmbLiaisonDepart.Items.Add(p);
                        cmbLiaisonArrivee.Items.Add(p);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion ou de lecture des ports : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                    maCnx.Close();
            }
        }

        private void btnLiaisonAjouter_Click(object sender, EventArgs e)
        {
            if (cmbLiaisonDepart.SelectedItem == null || cmbLiaisonArrivee.SelectedItem == null || lbxLiaisonSecteur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un port de départ, un port d'arrivée et un secteur.");
                return;
            }

            Port portDepart = (Port)cmbLiaisonDepart.SelectedItem;
            Port portArrivee = (Port)cmbLiaisonArrivee.SelectedItem;
            Secteur secteur = (Secteur)lbxLiaisonSecteur.SelectedItem;
            if (!double.TryParse(tbxLiaison.Text, out double distance))
            {
                MessageBox.Show("Veuillez entrer une distance valide.");
                return;
            }

            string query = "INSERT INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) " +
                           "VALUES (@portDepart, @secteur, @portArrivee, @distance)";
            try
            {
                if (maCnx.State == System.Data.ConnectionState.Closed)
                    maCnx.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@portDepart", portDepart.GetNoPort());
                    cmd.Parameters.AddWithValue("@secteur", secteur.GetNoSecteur());
                    cmd.Parameters.AddWithValue("@portArrivee", portArrivee.GetNoPort());
                    cmd.Parameters.AddWithValue("@distance", distance);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Liaison ajoutée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la liaison : {ex.Message}");
            }
            finally
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                    maCnx.Close();
            }
        }


    }
}
