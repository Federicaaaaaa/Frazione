using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione(8, 3);
           

            Frazione f2= new Frazione(11, 6);
            Console.WriteLine(f.Somma(f2));
            Frazione fparse = Frazione.Parse(f.ToString());
            //Console.WriteLine(fparse);

            Console.ReadLine();
        }
    }
}
