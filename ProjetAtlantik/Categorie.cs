using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Categorie
    {
        private string lettreCategorie;
        private string libelle;

        public Categorie(string lettreCategorie, string libelle)
        {
            this.lettreCategorie = lettreCategorie;
            this.libelle = libelle;
        }

        public string GetLettreCategorie()
        {
            return lettreCategorie;
        }

        public string GetLibelle()
        {
            return libelle;
        }

        public override string ToString()
        {
            return libelle;
        }
    }
}
