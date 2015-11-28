using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starter demo for ABAX..");
            //Ikke for å komme med unnskyldinger, men er første gang jeg jobber med C#. Da det er ganske frie tøyler for oppgaven, tar jeg et par valg
            //jeg har valgt å lage et program som bare går gjennom alt av seg selv, kunne like gjerne laget et menysystem med input. Men når det er formulert "programmet skal be bil 1 .."
            // virket det mer nøyaktig å gjøre det på denne måten. Men alt skjer ikke helt i rekkefølge. En annen løsning kunne vært å ventet på at en villkårling tast blir trykket

            //Bruker en del sleep så det blir litt tid å lese
            Bil bil1 = new Bil("NF123456", 147, 200, "Grønn", "Lett kjøretøy");
            //er skrivefeil i oppgaven(mest sannsynlig), står "let" kjøretøy. Rettet feilen
            Bil bil2 = new Bil("NF654321", 150, 195, "blå", "lett kjøretøy");



            Console.WriteLine("Skriver informasjon om bil 1 : ");
            bil1.skrivInformasjon();
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Skriver informasjon om bil 2 : ");
            bil2.skrivInformasjon();
            System.Threading.Thread.Sleep(5000);
            Console.Clear();


            Console.WriteLine("Er bil 1 og 2 samme kjøretøy?");
            bil1.sammenlign(bil2);
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Ber bil 1 om å kjøre..");
            bil1.kjør();
            System.Threading.Thread.Sleep(5000);

            Fly fly1 = new Fly("LN1234", 1000, 30, 2, 10, "jetfly");

            Console.Clear();
            Console.WriteLine("Ferdig med bil, printer informasjon om fly 1 :");
            fly1.skrivInformasjon();
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Ber flyet om å fly..");
            fly1.fly();



            Båt båt1 = new Båt("ABC123", 100, 30, 500);
            Console.WriteLine("Skriver ut informasjon om båten..");
            båt1.skrivInformasjon();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Avslutter om 10 sekunder..");
            System.Threading.Thread.Sleep(10000);







        }
    }
}
