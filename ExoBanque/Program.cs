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

            DateTime dt = new DateTime(1990, 1, 1);

            Personne p = new Personne("Luc", "Dubois", dt);

            Courant c = new Courant( "BE02...", p, 100 );

            // 0
            c.Retrait(100); 
            // -100
            c.Depot(100); 
            // 0
            c.Retrait(200); 
            // 0

            Console.WriteLine(c.Solde);
            Console.ReadLine();

        }
    }
}
