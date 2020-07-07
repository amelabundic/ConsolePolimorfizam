using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNasljedjivanje
{
    class KMRacun : Racun
    {
        public override void Isplata(double iznos)
        {
            provizija = 0.05;
            base.Isplata(iznos);

            if (stanje>(1 + provizija) * iznos)
            {
                stanje -= (1 + provizija) * iznos;
            }
            else
            {
                Console.WriteLine("Nemate dovoljno sredstava na racunu");
            }
        }
        public override void Stampaj()
        {
            Console.WriteLine("KM racun");
            base.Stampaj();
            Console.WriteLine("*********************************************");
        }
    }
}
