using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Secteur
    {
        public string nom;
        public int noSecteur;

        public Secteur(string nom, int noSecteur)
        {
            this.nom = nom;
            this.noSecteur = noSecteur;
        }
        public string GetNom()
        {
            return nom;
        }
        public int GetNoSecteur()
        {
            return noSecteur;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
