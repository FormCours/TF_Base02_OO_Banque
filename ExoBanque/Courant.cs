using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Courant
    {

        public string Numero { get; set; }
        public Decimal Solde { get; private set; }
        private Decimal _LigneDeCredit;

        public Decimal LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set {
                if (value >= 0)
                {
                    _LigneDeCredit = value;
                }
            }
        }

        public Personne Titulaire { get; set; }

        public Courant(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        public Courant(string numero, Personne titulaire, Decimal ligneDeCredit)
        {
            Numero = numero;
            Titulaire = titulaire;
            LigneDeCredit = ligneDeCredit;
        }


        public void Retrait(Decimal montant)
        {
            if( montant > 0 && montant <= Solde + LigneDeCredit )
                Solde -= montant;
        }

        public void Depot(Decimal montant)
        {
            if (montant > 0)
                Solde += montant;
        }



    }
}
