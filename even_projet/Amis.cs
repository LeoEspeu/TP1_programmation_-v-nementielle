using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_projet
{
    public class Amis : personne
    {
        private String note;

        public Amis(String pNote, string nom, string prenom, string adresse, string numeroTelephone) : base(nom, prenom, adresse, numeroTelephone)
        {
            this.note = pNote;
        }

        public override string ToString()
        {
            return "Amis \n" + base.ToString() + "\nNote : " + this.note;
        }

    }
}
