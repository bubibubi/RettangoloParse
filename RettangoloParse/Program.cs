using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RettangoloParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo(5, 3);
            Rettangolo r2;
            r2 = Rettangolo.Parse(r.ToString());
            Console.WriteLine(r2);

            Console.WriteLine("Ciao");

            Console.ReadLine();
        }
    }
}
