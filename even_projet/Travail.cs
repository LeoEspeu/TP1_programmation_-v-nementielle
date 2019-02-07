using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_projet
{
    public class Travail : personne
    {
        private int numeroBureau;

        public Travail(int pNumeroBureau ,string nom, string prenom, string adresse, string numeroTelephone) : base(nom, prenom, adresse, numeroTelephone)
        {
            this.numeroBureau = pNumeroBureau;
        }

        public override string ToString()
        {
            return "Travail\n" + base.ToString() + "\nNuméro de bureau : " + this.numeroBureau;
        }

    }
}
