using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Debuggen
{
    public class Telefoon
    {
        public List<string> GebeldeNummers { get; set; } = new List<string>();

        public void Bellen(string nummer)
        {
            if(!nummer.StartsWith("0") && !nummer.StartsWith("+"))
            {
                throw new ArgumentOutOfRangeException("Telefoonnummer moet starten met 0 of +");
            }

            if(nummer.StartsWith("0") && nummer.Length > 10)
            {
                throw new ArgumentOutOfRangeException("Telefoonnummer moet 10 tekens lang zijn");
            }

            if (nummer.StartsWith("+") && nummer.Length > 10)
            {
                throw new ArgumentOutOfRangeException("Telefoonnummer moet 12 tekens lang zijn");
            }

            GebeldeNummers.Add(nummer);

            Console.WriteLine($"Op dit moment wordt {nummer} gebeld. Tuuuuut, tuuuuut.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Error1();
            //Error2();
            //Error3(null);
        }

        static void Error1()
        {
            int[] array1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            for(int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    Console.WriteLine(array1[i] / array2[j]);
                }
            }
        }

        static void Error2()
        {
            //Point punt1 = new Point(0, 0);
        }

        static void Error3(string eenString)
        {

            Console.WriteLine($"Argument string '{eenString}' heeft een lengte van {eenString.Length} tekens");

        }

    }
}
