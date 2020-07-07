using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNasljedjivanje
{
    class DevizniRacun : Racun
    {
        public override void Isplata(double iznos)
        {
            base.Isplata(iznos);
            provizija = 0.06;

            if (stanje >(1 + provizija) * iznos)
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
            Console.WriteLine("EURO racun");
            base.Stampaj();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
        }
    }
}
