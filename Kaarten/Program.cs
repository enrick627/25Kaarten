//Enrick De Munter nr3 4/12/19 kaarten 5ITN
//v1: 2019/12/4 - demo voor emu
/*
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaarten
{
    class Program
    {
        enum Soort
        {
            Harten, 
            Klaveren,
            Ruiten,
            schoppen

        }

        static void Main(string[] args)
        {
            Soort soort;
            soort = Soort.Klaveren;
            string invoer;
            string soorttekst = soort.ToString();


            Console.WriteLine("wat is uw kaartsoort? : ");
            invoer = Console.ReadLine();

            soort =(Soort)Enum.Parse(typeof(Soort),invoer);


            Console.WriteLine($"de soort van de kaart is {soort.ToString().ToLower()}.");

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten:");
            Console.ReadKey();
        }
    }
}
