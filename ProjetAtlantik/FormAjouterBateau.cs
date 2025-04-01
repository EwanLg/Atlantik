using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAtlantik
{
    public partial class FormAjouterBateau : Form
    {
        private MySqlConnection maCnx;

        public FormAjouterBateau(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
        }
        private void FormAjouterBateau_Load(object sender, EventArgs e)
        {

            try
            {
                
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();

                string query = "SELECT * FROM categorie";
                int i = 1;
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();
                {
                    while (jeuEnr.Read())
                    {
                        Label lblCategorie = new Label();
                        lblCategorie.Text = jeuEnr["lettrecategorie"] + " (" + jeuEnr["libelle"] + " ) : ";
                        lblCategorie.Location = new Point(10, i * 50);
                        gbxCapacitesAjouterBateau.Controls.Add(lblCategorie);

                        TextBox tbxCategorie = new TextBox();
                        tbxCategorie.Tag = jeuEnr["lettrecategorie"];
                        tbxCategorie.Location = new Point(125, i * 50);
                        gbxCapacitesAjouterBateau.Controls.Add(tbxCategorie);
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

        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {
            if (tbxNomBateau == null)
            {
                MessageBox.Show("Veuillez entrer un nom pour le bateau.");
                return;
            }

            bool capacitesSaisi = false;
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control control in gbxCapacitesAjouterBateau.Controls)
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
                MessageBox.Show("Veuillez renseigner des capacitées.");
                return;
            }
            int idbateau = -1;
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();
                string query = "INSERT INTO bateau (NOM) VALUES (@nom); select last_insert_id();";
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                {
                    cmd.Parameters.AddWithValue("@nom", tbxNomBateau.Text);
                    idbateau = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du bateau : {ex.Message}");
            }
            if (idbateau == -1)
            {
                MessageBox.Show("Erreur : L'ID du bateau n'a pas été récupéré.");
                return;
            }
            foreach (TextBox tbxCapacite in textBoxes)
            {
                string lettreCategorie = tbxCapacite.Tag.ToString().Substring(0, 1);
                string query = "INSERT INTO contenir (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettrecategorie, @nobateau, @capacitemax)";
                    try
                    {
                        if (maCnx.State == ConnectionState.Closed)
                            maCnx.Open();

                        
                        MySqlCommand cmd = new MySqlCommand(query, maCnx);
                        {
                            cmd.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                            cmd.Parameters.AddWithValue("@nobateau", idbateau);
                            cmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxCapacite.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'ajout des capacitées du bateau : {ex.Message}");
                    }
                    finally
                    {
                        if (maCnx.State == ConnectionState.Open)
                            maCnx.Close();
                    }
                }
            MessageBox.Show("Bateau ajoutés avec succès !");
        }
    }
}
