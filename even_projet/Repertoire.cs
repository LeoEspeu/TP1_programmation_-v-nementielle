using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_projet
{
    public class Repertoire
    {
        private List<personne> lesPersonnes;

        public Repertoire()
        {
            this.lesPersonnes = new List<personne>();
        }

        public void Ajouter(personne laPersonne)
        {
            this.lesPersonnes.Add(laPersonne);
        }

        public void Supprimmer(personne laPersonne)
        {
            this.lesPersonnes.Remove(laPersonne);
        }

        public List<personne> LesPersonnes { get => lesPersonnes; }


    }
}
