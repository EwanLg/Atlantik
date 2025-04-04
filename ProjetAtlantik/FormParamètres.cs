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
    public partial class FormParamètres : Form
    {
        private MySqlConnection maCnx;
        public FormParamètres(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
        }
        private void ChargerParametres()
        {
            try
            {
                if (maCnx.State != ConnectionState.Open)
                {
                    maCnx.Open();
                }

                string query = "SELECT SITE_PB, RANG_PB, IDENTIFIANT_PB, CLEHMAC_PB, ENPRODUCTION, MELSITE FROM parametres LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tbxSite.Text = reader["SITE_PB"].ToString();
                    tbxRang.Text = reader["RANG_PB"].ToString();
                    tbxId.Text = reader["IDENTIFIANT_PB"].ToString();
                    tbxKey.Text = reader["CLEHMAC_PB"].ToString();
                    cbxProduction.Checked = Convert.ToBoolean(reader["ENPRODUCTION"]);
                    tbxMail.Text = reader["MELSITE"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des paramètres : {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
        }

        private void FormParamètres_Load(object sender, EventArgs e)
        {
            ChargerParametres();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSite.Text) ||
                string.IsNullOrWhiteSpace(tbxRang.Text) ||
                string.IsNullOrWhiteSpace(tbxId.Text) ||
                string.IsNullOrWhiteSpace(tbxKey.Text) ||
                string.IsNullOrWhiteSpace(tbxMail.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                if (maCnx.State != ConnectionState.Open)
                {
                    maCnx.Open();
                }

                string query = "UPDATE parametres SET SITE_PB = @sitepb, RANG_PB = @rangpb, IDENTIFIANT_PB = @identifiantpb, " +
                               "CLEHMAC_PB = @clehmac, ENPRODUCTION = @enproduction, MELSITE = @melsite";

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@sitepb", tbxSite.Text);
                cmd.Parameters.AddWithValue("@rangpb", tbxRang.Text);
                cmd.Parameters.AddWithValue("@identifiantpb", tbxId.Text);
                cmd.Parameters.AddWithValue("@clehmac", tbxKey.Text);
                cmd.Parameters.AddWithValue("@enproduction", cbxProduction.Checked);
                cmd.Parameters.AddWithValue("@melsite", tbxMail.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paramètres modifiés avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des paramètres : {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
        }
    }
}
