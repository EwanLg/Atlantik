using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetAtlantik
{
    public partial class FormAjouterPort : Form
    {
        private MySqlConnection maCnx;

        public FormAjouterPort(MySqlConnection connexion)
        {
            InitializeComponent();
            maCnx = connexion;
        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxAjouterPort.Text))
            {
                MessageBox.Show("Le nom du port ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO port (nom) VALUES (@NomPort)";

            try
            {
                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                {
                    cmd.Parameters.AddWithValue("@NomPort", tbxAjouterPort.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Port ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxAjouterPort.Clear();
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
