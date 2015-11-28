using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Bil
    {
     private string registreringsnummer { get; set; }
     private int effekt { get; set; }
     private int maksfart { get; set; }
     private string farge { get; set; }
     private string type { get; set; }

        //Har også sett en shorthand for konstuktør i C#?
        public Bil(string regnr, int effekt, int maksfart, string farge, string type)
        {
            registreringsnummer = regnr;
            this.effekt = effekt;
            this.maksfart = maksfart;
            this.farge = farge;
            this.type = type;
        }


        //sammenligner bare regnr, da det er unikt
        public void sammenlign(Bil bil2)
        {
            if(registreringsnummer == bil2.registreringsnummer)
            {
                Console.WriteLine("Bilene er like");
            }
            else
            {
                Console.WriteLine("Bilene er ulike");
            }
        }


        //kunne også vært en streng
        public void skrivInformasjon()
        {
            Console.WriteLine("Registreringsnummer:" + registreringsnummer + ". ");
            Console.WriteLine("Effekt:" + effekt + " kw. ");
            Console.WriteLine("Maksfart:" + maksfart + " km/t. ");
            Console.WriteLine("Farge:" + farge + ". ");
            Console.WriteLine("Type:" + type + ". ");

        }

        //Dette var litt vagt, valgte å tolke det på min egen måte
        public void kjør()
        {

            Console.WriteLine("     ___  ");
            Console.WriteLine("   _/___\\ ");
            Console.WriteLine("    O   O");
            Console.WriteLine("   -------------------");

            
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("      ___  ");
            Console.WriteLine("    _/___\\ ");
            Console.WriteLine("     O   O");
            Console.WriteLine("   -------------------");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();


            Console.WriteLine("          ___  ");
            Console.WriteLine("        _/___\\ ");
            Console.WriteLine("         O   O");
            Console.WriteLine("   -------------------");


            System.Threading.Thread.Sleep(1000);
            Console.Clear();


            Console.WriteLine("              ___  ");
            Console.WriteLine("            _/___\\ ");
            Console.WriteLine("             O   O");
            Console.WriteLine("   -------------------");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();


            Console.WriteLine("                  ___  ");
            Console.WriteLine("                _/___\\ ");
            Console.WriteLine("                 O   O");
            Console.WriteLine("   -------------------");

        }


    }
}
