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
    public partial class FormAccueil : Form
    {
        private MySqlConnection maCnx;
        public FormAccueil(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
        }

        private void ajouterUnBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterBateau Form = new FormAjouterBateau(maCnx);
            Form.ShowDialog();
        }

        private void ajouterUnPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterPort Form = new FormAjouterPort(maCnx);
            Form.ShowDialog();
        }

        private void ajouterUnSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterSecteur Form = new FormAjouterSecteur(maCnx);
            Form.ShowDialog();
        }

        private void ajouterUneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLiaison Form = new FormLiaison(maCnx);
            Form.ShowDialog();
        }

        private void ajouterDesTarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarifs Form = new FormTarifs(maCnx);
            Form.ShowDialog();
        }

        private void ajouterUneTraverséeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraversée Form = new FormTraversée(maCnx);
            Form.ShowDialog();
        }

        private void détailsDesRéservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDétailsRéservation Form = new FormDétailsRéservation(maCnx);
            Form.ShowDialog();
        }

        private void placeDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlaceDispo Form = new FormPlaceDispo(maCnx);
            Form.ShowDialog();
        }
    }
}
