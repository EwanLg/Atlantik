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
    public partial class FormModifierBateau : Form
    {
        private MySqlConnection maCnx;
        public FormModifierBateau(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
            cmbModifierBateau.SelectedIndexChanged += cmbModifierBateau_SelectedIndexChanged;
        }

        private void FormModifierBateau_Load(object sender, EventArgs e)
        {
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
                        cmbModifierBateau.Items.Add(b);
                    }
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
        private void ChargerCapacite(int noBateau)
        {
            gbxCapacitesModifierBateau.Controls.Clear();
            try
                {

                    if (maCnx.State == ConnectionState.Closed)
                        maCnx.Open();

                string query = "SELECT c.lettrecategorie, c.libelle, co.capacitemax " +
                                       "FROM categorie c " +
                                       "LEFT JOIN contenir co ON c.lettrecategorie = co.lettrecategorie " +
                                       "WHERE co.nobateau = @noBateau";
                    int i = 1;
                    MySqlCommand cmd = new MySqlCommand(query, maCnx);
                    cmd.Parameters.AddWithValue("@noBateau", noBateau);
                    MySqlDataReader jeuEnr = cmd.ExecuteReader();
                    {
                        while (jeuEnr.Read())
                        {
                            Label lblCategorie = new Label();
                            lblCategorie.Text = jeuEnr["lettrecategorie"] + " (" + jeuEnr["libelle"] + " ) : ";
                            lblCategorie.Location = new Point(10, i * 50);
                            gbxCapacitesModifierBateau.Controls.Add(lblCategorie);

                            TextBox tbxCategorie = new TextBox();
                            tbxCategorie.Text = jeuEnr.GetInt32("capacitemax").ToString();
                            tbxCategorie.Tag = jeuEnr["lettrecategorie"];
                            tbxCategorie.Location = new Point(125, i * 50);
                            gbxCapacitesModifierBateau.Controls.Add(tbxCategorie);
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

        private void cmbModifierBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModifierBateau.SelectedItem != null)
            {
                Bateau bateauSelectionner = (Bateau)cmbModifierBateau.SelectedItem;
                int noBateau = bateauSelectionner.GetNoBateau();
                ChargerCapacite(noBateau);
            }
        }
        private void btnModiferBateau_Click(object sender, EventArgs e)
        {
            if (cmbModifierBateau.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez un bateau.");
                return;
            }

            bool capacitesSaisi = false;
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control control in gbxCapacitesModifierBateau.Controls)
            {
                if (control is TextBox tbxCapacite)
                {
                    textBoxes.Add(tbxCapacite);
                }
            }

            foreach (TextBox tbxCapacite in textBoxes)
            {
                if (!string.IsNullOrEmpty(tbxCapacite.Text))
                {
                    capacitesSaisi = true;
                    break;
                }
            }

            if (!capacitesSaisi)
            {
                MessageBox.Show("Veuillez renseigner des capacités.");
                return;
            }

            int idbateau = -1;
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();
                string query = "SELECT nobateau FROM bateau WHERE NOM = @nom";
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@nom", cmbModifierBateau.Text);
                idbateau = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du bateau : {ex.Message}");
            }

            if (idbateau == -1)
            {
                MessageBox.Show("Erreur : L'ID du bateau n'a pas été récupéré.");
                return;
            }
            foreach (TextBox tbxCapacite in textBoxes)
            {
                string lettreCategorie = tbxCapacite.Tag.ToString().Substring(0, 1);

                try
                {
                    if (maCnx.State == ConnectionState.Closed)
                        maCnx.Open();

                    string updateQuery = "UPDATE contenir SET CAPACITEMAX = @capacitemax WHERE LETTRECATEGORIE = @lettrecategorie AND NOBATEAU = @nobateau";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, maCnx);
                    updateCmd.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                    updateCmd.Parameters.AddWithValue("@nobateau", idbateau);
                    updateCmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxCapacite.Text));
                    updateCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour des capacités du bateau : {ex.Message}");
                }
                finally
                {
                    if (maCnx.State == ConnectionState.Open)
                        maCnx.Close();
                }
            }

            MessageBox.Show("Capacités du bateau mises à jour avec succès !");
        }

    }
}
