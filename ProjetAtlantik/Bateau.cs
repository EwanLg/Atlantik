using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Bateau
    {
        private string nom;
        private int noBateau;

        public Bateau(string nom, int noBateau)
        {
            this.nom = nom;
            this.noBateau = noBateau;
        }
        public string GetNom()
        {
            return nom;
        }
        public int GetNoBateau()
        {
            return noBateau;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
