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

        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterSecteur Form = new FormAjouterSecteur(maCnx);
            Form.ShowDialog();
        }

        private void unPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterPort Form = new FormAjouterPort(maCnx);
            Form.ShowDialog();
        }

        private void uneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLiaison Form = new FormLiaison(maCnx);
            Form.ShowDialog();
        }

        private void lesTarifsPourUneliaisonEtUnePériodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarifs Form = new FormTarifs(maCnx);
            Form.ShowDialog();
        }

        private void unBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterBateau Form = new FormAjouterBateau(maCnx);
            Form.ShowDialog();
        }

        private void uneTraverséeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraversée Form = new FormTraversée(maCnx);
            Form.ShowDialog();
        }

        private void unBateauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModifierBateau Form = new FormModifierBateau(maCnx);
            Form.ShowDialog();
        }

        private void lesParamètresDuSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParamètres Form = new FormParamètres(maCnx);
            Form.ShowDialog();
        }

        private void lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlaceDispo Form = new FormPlaceDispo(maCnx);
            Form.ShowDialog();
        }

        private void lesDétailsDuneRéservationPourUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDétailsRéservation Form = new FormDétailsRéservation(maCnx);
            Form.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pas encore disponible.");
        }
    }
}
