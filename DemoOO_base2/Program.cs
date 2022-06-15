
using DemoOO.Enfant;
using EE = DemoOO.Enfant.Enfant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoOO.Classes;

namespace DemoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" NAMESPACE ");
            MaClasse m;
            EE.MaClasse m2;
            EE.Final.AutreClass ac;


            Console.WriteLine(" CLASSE ");

            Voiture v = new Voiture();
            
            v.Prix2 = Double.Parse( Console.ReadLine() );
            v.Prix2 += v.Prix2;

            double promotion = v.Prix2 * (80 / 100);
            v.Prix2 = promotion;

            //v.KmParcouru = 50;
        }
    }

    
}

