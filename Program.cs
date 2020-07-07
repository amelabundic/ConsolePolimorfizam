using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNasljedjivanje
{
    class Program
    {
        static void Main(string[] args)
        {

           // KMRacun r1 = new KMRacun { Ime = "Pera", Prezime = "Peric" };
            //r1.Stampaj();
            //r1.Uplata(6752);
            //r1.Stampaj();

            //r1.Isplata(1923);
            //r1.Stampaj();


            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();

            DevizniRacun dev1 = new DevizniRacun { Ime = ime, Prezime = prezime };
            dev1.Stampaj();
            
            string novaTransakcija = "n";
            string transakcija = "";

            //1 za uplatu
            //2 za isplatu

            double iznos;

            do
            {
                Console.WriteLine("Odaberite transakciju");
                Console.WriteLine("1-->> Za uplatu");
                Console.WriteLine("2-->> Za isplatu");

                transakcija = Console.ReadLine();

                if (transakcija =="1")
                {
                    //Uplata na racun
                    Console.WriteLine("Koliko EURA uplacujete?");
                    iznos = double.Parse(Console.ReadLine());
                    dev1.Uplata(iznos);
                    dev1.Stampaj();

                }   
                else if (transakcija =="2")
                {
                    //uplata na euro racun
                    Console.WriteLine("Koliko EURA podizete?");
                    iznos = double.Parse(Console.ReadLine());
                    dev1.Isplata(iznos);
                    dev1.Stampaj();

                }
                else
                {
                    Console.WriteLine("Niste odabrali transakciju");
                }
                Console.WriteLine("Da li zelite novu transakciju?");
                Console.WriteLine("DA ---Pritisnite d");
                Console.WriteLine("Pritisnite bilo koji drugi taster");

                novaTransakcija = Console.ReadLine();
                
            } while (novaTransakcija == "D" || novaTransakcija =="d");
            Console.ReadLine();
        }
    }
}
