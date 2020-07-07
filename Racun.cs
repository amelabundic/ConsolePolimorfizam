using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNasljedjivanje
{
    class Racun
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        protected double stanje;
        protected double provizija;

        public void Uplata(double iznos)
        {
            Console.WriteLine($"TRANSAKCIJA UPLATA:{iznos}");
            stanje += iznos;
        }
        public virtual void Isplata(double iznos)
        {
            Console.WriteLine($"TRANSAKCIJA ISPLATA: :{iznos}");
        }

        public virtual void Stampaj()
        {
            Console.WriteLine($"{Ime} {Prezime} {stanje}");
        }
    }
}
