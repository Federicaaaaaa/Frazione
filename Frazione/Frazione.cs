using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }
        public Frazione(int num, int den) 
        {
            Semplificazione(ref num, ref den);
            Numeratore = num;
            Denominatore = den;
        }
        public void Semplificazione(ref int num, ref int den)
        {
            //MCD
            int resto;
            int a = num;
            int b = den;
            while(b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            int MCD = a;
            //Semplificare
            den = den / MCD;
            num = num / MCD;
        }
        public override string ToString()
        {
            //return string.Format("{0}/{1}", Numeratore, Denominatore);
             return $"{Numeratore}/{Denominatore}";
        }
        public static Frazione Parse(string fraction)
        {
            string[] subs = fraction.Split('/');
            return new Frazione(int.Parse(subs[0]), int.Parse(subs[1]));
        }

        public Frazione Somma(Frazione f)
        {
            return new Frazione(Denominatore * f.Numeratore + Numeratore * f.Denominatore, f.Denominatore * Denominatore);
        }
    }
}
