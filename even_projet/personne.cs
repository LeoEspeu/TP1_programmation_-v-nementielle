using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_projet
{
    public class personne
    {
        private String nom;

        private String prenom;

        private String adresse;

        private String numeroTelephone;

        public personne(string nom, string prenom, string adresse, string numeroTelephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.numeroTelephone = numeroTelephone;
        }

        public override string ToString()
        {
            return "Identité : " + this.nom + " - " + this.prenom + "\nAdresse : " + this.adresse + "\nTéléphone : " + this.numeroTelephone;
        }
    }
}
