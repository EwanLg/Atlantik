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
        private DateTime dateHeureDepart;
        private string nomBateau;

        public Traversee(int noTraversee, DateTime dateHeureDepart, string nomBateau)
        {
            this.noTraversee = noTraversee;
            this.dateHeureDepart = dateHeureDepart;
            this.nomBateau = nomBateau;
        }

        public int GetNoTraversee()
        {
            return noTraversee;
        }

        public DateTime GetDateHeureDepart()
        {
            return dateHeureDepart;
        }

        public string GetNomBateau()
        {
            return nomBateau;
        }

        public override string ToString()
        {
            return $"{nomBateau} - {dateHeureDepart.ToShortTimeString()}";
        }
    }
}
