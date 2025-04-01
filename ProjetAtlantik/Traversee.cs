using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Traversee
    {
        private int noTraversee;
        private DateTime heureDepart;
        private string nomBateau;

        public Traversee(int noTraversee, DateTime heureDepart, string nomBateau)
        {
            this.noTraversee = noTraversee;
            this.heureDepart = heureDepart;
            this.nomBateau = nomBateau;
        }

        public int GetNoTraversee()
        {
            return noTraversee;
        }

        public DateTime GetHeureDepart()
        {
            return heureDepart;
        }

        public string GetNomBateau()
        {
            return nomBateau;
        }

        public override string ToString()
        {
            return $"{nomBateau} - {heureDepart.ToShortTimeString()}";
        }
    }
}
