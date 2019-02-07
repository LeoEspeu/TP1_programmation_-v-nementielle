using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_projet
{
    public class Famille : personne
    {
        private String relationFamiliale;

        public Famille(String pRelationFamiliale, string nom, string prenom, string adresse, string numeroTelephone) : base(nom, prenom, adresse, numeroTelephone)
        {
            this.relationFamiliale = pRelationFamiliale;
        }

        public override string ToString()
        {
            return "Famille\n" + base.ToString() + "\nRelation : " + this.relationFamiliale;
        }
    }
}
