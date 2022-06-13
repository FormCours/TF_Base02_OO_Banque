using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    class Banque
    {
        #region Champs
        // Dico avec en clef "numero de compte" et en valeur "le compte"
        private Dictionary<string, Courant> _Comptes;
        #endregion

        #region Props
        public string Nom { get; set; }
        #endregion

        #region Ctor
        public Banque(string nom)
        {
            this.Nom = nom;

            // Initialisation du dico des comptes
            this._Comptes = new Dictionary<string, Courant>();
        }
        #endregion

        public void Ajouter(Courant compte)
        {
            string numero = compte.Numero;

            if(_Comptes.ContainsKey(numero))
            {
                // Le compte existe deja :o
                return; // -> A remplacer par une erreur
            }
            _Comptes.Add(numero, compte);
        }
    }
}
