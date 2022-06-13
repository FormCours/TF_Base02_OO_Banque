using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Personne
    {
        #region Auto-Props 
        // Les valeurs de "champs" sont généré automatiquement
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaiss { get; set; }
        #endregion

        #region Constructeur 
        // -> Permet d'initialiser l'objet
        public Personne(string prenom, string nom, DateTime dateNaiss)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaiss = dateNaiss;
        }
        #endregion

    }
}
