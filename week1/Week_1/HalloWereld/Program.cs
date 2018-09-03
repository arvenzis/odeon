using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWereld
{
    class Program
    {
        static void Main(string[] args)
        {

            //CijfersTellen();
            Vragen();
        }

        static void Vragen()
        {
            bool doorgaan = true;
            string naam = "Trumptower";
            while (doorgaan)
            {
                Console.WriteLine("1 Wat is het lievelingseten van {0}?", naam);
                Console.WriteLine("2 Wat is {0} zijn lievelings gebouw?", naam);
                Console.WriteLine("3 Kies drie om het programma te verlaten");

                int keuze = Convert.ToInt16(Console.ReadLine());
                if(keuze == 1)
                {
                    Console.WriteLine("Pizza");
                }else if(keuze == 2)
                {
                    Console.WriteLine("Eifeltoren");
                }else if(keuze == 3)
                {
                    doorgaan = false;
                }
                else
                {
                    Console.WriteLine("Er is geen geldige keuze gemaakt. Kies opnieuw");
                }

            }


        }

        static void CijfersTellen()
        {
            int[] cijfers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (var i = 0; i < cijfers.Length; i++)
            {
                Console.WriteLine(cijfers[i]);
            }
        }
    }
}
