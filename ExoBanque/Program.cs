using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialisation des elements");
            DateTime dt = new DateTime(1990, 1, 1);
            Personne p = new Personne("Luc", "Dubois", dt);
            Courant c = new Courant( "BE02...", p, 100 );

            // Opération sur le compte courant (Sodle 0)
            Console.WriteLine($"Initial : {c.Numero} - Solde: {c.Solde}");

            // - Retrait de 100€
            c.Retrait(100);
            Console.WriteLine($"Retrait de 100 : {c.Numero} - Solde: {c.Solde}");

            // - Depot de 100€
            c.Depot(100);
            Console.WriteLine($"Depot de 100 : {c.Numero} - Solde: {c.Solde}");
            
            // - Retrait de 200€. Refusé => Ligne de credit !
            c.Retrait(200);
            Console.WriteLine($"Retrait de 200 : {c.Numero} - Solde: {c.Solde} (Refusé)");


        }
    }
}
