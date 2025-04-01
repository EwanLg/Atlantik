using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Liaison
    {
        private int noPort_Depart;
        private int noPort_Arrivee;
        private int noSecteur;
        private int noLiaison;
        private string nomPortDepart;
        private string nomPortArrivee;

        public Liaison(int noPort_Depart, int noPort_Arrivee, int noSecteur, int noLiaison, string nomPortDepart, string nomPortArrivee)
        {
            this.noPort_Depart = noPort_Depart;
            this.noPort_Arrivee = noPort_Arrivee;
            this.noSecteur = noSecteur;
            this.noLiaison = noLiaison;
            this.nomPortDepart = nomPortDepart;
            this.nomPortArrivee = nomPortArrivee;
        }
        public int GetNoPort_Depart()
        {
            return noPort_Depart;
        }
        public int GetNoPort_Arrivee()
        {
            return noPort_Arrivee;
        }
        public int GetNoSecteur()
        {
            return noSecteur;
        }
        public int GetNoLiaison()
        {
            return noLiaison;
        }
        public string GetNomPortDepart()
        {
            return nomPortDepart;
        }
        public string GetNomPortArrivee()
        {
            return nomPortArrivee;
        }
        public override string ToString()
        {
            return nomPortDepart + " -> " + nomPortArrivee;
        }
    }
}