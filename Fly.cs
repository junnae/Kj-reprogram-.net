using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{

    //kunne kanskje brukt arv, en overklasse kalt "kjøretøy"
    class Fly
    {
        private string kjennetegn { get; set; }
        private int effekt { get; set; }
        private int vingespenn { get; set; }
        private int lasteevne { get; set; }
        private int egenvekt { get; set; }
        private string flyklasse { get; set; }

        //Har også sett en shorthand for konstuktør i C#?
        public Fly(string kjennetegn, int effekt, int vingespenn, int lasteevne, int egenvekt, string flyklasse)
        {
            this.kjennetegn = kjennetegn;
            this.effekt = effekt;
            this.vingespenn = vingespenn;
            this.lasteevne = lasteevne;
            this.egenvekt = egenvekt;
            this.flyklasse = flyklasse;
        }



        public void skrivInformasjon()
        {
            Console.WriteLine("Kjennetegn:" + kjennetegn + ". ");
            Console.WriteLine("Effekt:" + effekt + " kw. ");
            Console.WriteLine("Vingespenn:" + vingespenn + " m. ");
            Console.WriteLine("Lasteevne:" + lasteevne + " tonn. ");
            Console.WriteLine("Egenvekt:" + egenvekt + " tonn. ");
            Console.WriteLine("Flyklasse:" + flyklasse + ". ");

        }

        public void fly()
        {

            Console.WriteLine("            ");
            Console.WriteLine("      \\\\ ___________________     ");
            Console.WriteLine("       \\\\ _____\\\\_______/_) ");
            Console.WriteLine("   --------------------------------------");


            System.Threading.Thread.Sleep(3000);
            Console.Clear();

                                         
            Console.WriteLine("            Q ");
            Console.WriteLine("          / /");
            Console.WriteLine("         / /      ");
            Console.WriteLine("        / /       ");
            Console.WriteLine("     __/_/   ");
            Console.WriteLine("                ");
            Console.WriteLine("   -------------------");

            System.Threading.Thread.Sleep(3000);
            Console.Clear();



            Console.WriteLine("            ");
            Console.WriteLine("      \\\\ ___________________     ");
            Console.WriteLine("       \\\\ _____\\\\_______/_) ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("   --------------------------------------");


            System.Threading.Thread.Sleep(3000);
            Console.Clear();


            Console.WriteLine("            ");
            Console.WriteLine("              \\\\ ___________________     ");
            Console.WriteLine("               \\\\ _____\\\\_______/_) ");
            Console.WriteLine("                   ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("   --------------------------------------");


            System.Threading.Thread.Sleep(3000);
            Console.Clear();

        }


    }
}

