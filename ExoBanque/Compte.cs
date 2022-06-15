using System;

namespace ExoBanque
{
    internal class Compte
    {
        public string Numero { get; set; }
        public decimal Solde { get; private set; }
        public Personne Titulaire { get; set; }

        public void Depot(decimal montant)
        {
            if (montant > 0)
                Solde += montant;
        }

        public virtual void Retrait(decimal montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(decimal montant, decimal ligneDeCredit)
        {
            if (montant <= 0)
            {
                Console.WriteLine("montant incorrecte");
                return; //Déclencher une erreur
            }

            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return; //Déclencher une erreur
            }

            Solde -= montant;
        }
    }
}