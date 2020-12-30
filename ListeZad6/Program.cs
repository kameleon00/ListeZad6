using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gradovi = new Dictionary<string, int>()
            {
                {"Beograd", 2000000 },
                {"Nis", 1400000 },
                {"Kraljevo", 400000 }
            };

            foreach (var grad in gradovi)
                Console.WriteLine(grad);
            Console.WriteLine("=======================================");
            Console.WriteLine("Drugi nacin ispisa sa KeyValuePair:");
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=================================================");

            try
            {
                gradovi.Add("Novi Sad", 340233);
                gradovi.Add("Beograd", 2000000);
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("=================================================");

            }

            Console.WriteLine("Nakon dodavanja:");

            foreach (var grad in gradovi)
                Console.WriteLine(grad);
            Console.WriteLine("=======================================");
            Console.WriteLine("Drugi nacin ispisa sa KeyValuePair:");
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=======================================");

            Console.ReadLine();
        }
    }
}

