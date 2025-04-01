using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Clients
    {
        private int noClient;
        private string nom;
        private string prenom;
        public Clients(int noClient, string nom, string prenom)
        {
            this.noClient = noClient;
            this.nom = nom;
            this.prenom = prenom;
        }
        public int getNoClient()
        {
            return noClient;
        }
        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public override string ToString()
        {
            return nom + ", " + prenom;
        }
    }
}
