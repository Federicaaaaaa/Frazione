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
            Frazione f = new Frazione(5, 25);
            Console.WriteLine(f);

            Frazione fparse = Frazione.Parse(f.ToString());
            Console.WriteLine(fparse);

            Console.ReadLine();
        }
    }
}
