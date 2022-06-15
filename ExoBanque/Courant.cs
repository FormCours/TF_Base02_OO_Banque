using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Courant : Compte
    {
        #region Champs
        private decimal _LigneDeCredit;
        #endregion

        #region Propriétés
        public decimal LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set {
                if (value >= 0)
                {
                    _LigneDeCredit = value;
                }
            }
        }
        #endregion

        #region Constructeurs
        public Courant(string numero, Personne titulaire)
        {
            Numero = numero.ToUpper();
            Titulaire = titulaire;
            LigneDeCredit = 0;
        }

        public Courant(string numero, Personne titulaire, decimal ligneDeCredit)
            : this(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }
        #endregion

        #region Méthodes
        public override void Retrait(decimal montant)
        {
            Retrait(montant, LigneDeCredit);
        }
        #endregion
    }
}
