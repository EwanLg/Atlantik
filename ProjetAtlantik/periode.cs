using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Periode
    {
        private DateTime datedebut, datefin;
        private int noPeriode;

        public Periode(DateTime datedebut, DateTime datefin, int noPeriode)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.noPeriode = noPeriode;
        }
        public DateTime GetDateDebut()
        {
            return datedebut;
        }
        public DateTime GetDateFin()
        {
            return datefin;
        }
        public int GetNoPeriode()
        {
            return noPeriode;
        }
        public override string ToString()
        {
            return datedebut.ToString("dd/MM/yyyy") + " au " + datefin.ToString("dd/MM/yyyy");
        }
    }
}
