using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Personne
    {

        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaiss { get; set; }

        public Personne(string prenom, string nom, DateTime dateNaiss)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaiss = dateNaiss;
        }

    }
}
