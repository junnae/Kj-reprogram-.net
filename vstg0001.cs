using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Båt
    {
        //siden mange av de samme gjenbrukes hadde det vel vært relevant med noe form for arv
        private string kjennetegn { get; set; }
        private int effekt { get; set; }
        private int maksfart { get; set; }
        private int bruttoTonnasje { get; set; }

        //Har også sett en shorthand for konstuktør i C#?
        public Båt(string kjennetegn, int effekt, int maksfart, int brTonnasje)
        {
            this.kjennetegn = kjennetegn;
            this.effekt = effekt;
            this.maksfart = maksfart;
            bruttoTonnasje = brTonnasje;

        }


        public void skrivInformasjon()
        {
            Console.WriteLine("Kjennetegn:" + kjennetegn + ". ");
            Console.WriteLine("Effekt:" + effekt + " kw. ");
            Console.WriteLine("Maksfart:" + maksfart + " knop. ");
            Console.WriteLine("Bruttotonnasje:" + bruttoTonnasje + "kg. ");

        }

    }
}
