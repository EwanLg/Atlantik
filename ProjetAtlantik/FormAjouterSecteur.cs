using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetAtlantik
{
    public partial class FormAjouterSecteur : Form
    {
        private MySqlConnection maCnx;

        public FormAjouterSecteur(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxAjouterSecteur.Text))
            {
                MessageBox.Show("Le nom du secteur ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO secteur (nom) VALUES (@NomSecteur)";

            try
            {
                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                {
                    cmd.Parameters.AddWithValue("@NomSecteur", tbxAjouterSecteur.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Secteur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxAjouterSecteur.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur d'insertion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
    }
}
