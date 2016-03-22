using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace peli
{
    class Program
    {

        static void Main(string[] args)
        {
            string liike ="0",liike2="1";
            ///stopwatch = Stopwatch.StartNew();
            ///
            hahmo pelaaja,hirvio; // ESITTELY !!

            pelaaja = new hahmo();
            hirvio = new hahmo();

            while (liike!= "5"){
                //Console.Clear();
                Console.WriteLine("1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU");
                liike = Console.ReadLine();
                //Console.ReadLine();
                //Console.Read();
                //Console.Read();
                //Console.Clear();
                //Thread.Sleep(500);

                //stopwatch = Stopwatch.StartNew();
                //Thread.Sleep(5000);
                //stopwatch.Stop();

                //Console.ReadKey();
                //if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                //Console.WriteLine(" kokoko");
                switch (liike)
                {
                    case "1": Console.WriteLine("Poh"); break;
                    case "2": Console.WriteLine("Itä"); break;
                    case "3": Console.WriteLine("Etelä"); break;
                    case "4": Console.WriteLine("Länsi"); break;
                    //default : Console.Clear(); break;
                }

                ///Console.Clear();
                //Console.Read();
                //Console.Clear();
                //switch()
                Random rnd = new Random();
                switch(rnd.Next(0, 4))
                {
                    case 0 : Console.WriteLine("Ei mitään"); break;
                    case 1 : Console.WriteLine("Kirves"); break;
                             
                    case 2 : Console.WriteLine("Miekka"); break;
                    case 3 : Console.WriteLine("Hirviö!");
                             Console.WriteLine("Hyökkää 1. Pakene 2.");
                             liike2 = Console.ReadLine();
                             //taistelu(liike2);
                             break;
                }
                
            }
            /*private void taistelu(string parametri)
            {

            }*/
        }
    }

    public class hahmo // public !!!
    {
        private int ase; // 1 kirves 2 miekka
        private int kirves; // 1-20
        private int miekka; // 5-15

        private int voima; // ?
        private int nopeus; // ?
        private int terveys; // 1-100

        public hahmo() // sulut!!
        { // sulut !!
            this.ase = 2;
            this.kirves = 10;
            this.miekka = 10;
            this.voima = 10; // ?
            this.nopeus = 10; // ?
            this.terveys = 100; // 1-100
        }

        public int Ase
        {
            get { return ase; }
            set { ase = value; }
        }

        public int Kirves
        {
            get { return kirves; }
            set { kirves = value; }
        }

        public int Miekka
        {
            get { return miekka; }
            set { miekka = value; }
        }
    }

  /*  public class taistelu
    {
        
    }*/
}
    /*            switch (liike2)
        {
            case "1":
                switch (pelaaja2.ase)
                {
                    case 1: hirvio2.terveys -= rnd.Next(0, pelaaja2.kirves); break;
                    case 2: hirvio2.terveys -= rnd.Next(0, pelaaja2.miekka); break;
                }

                break;
            case "2": break;
        }
        Console.WriteLine("Hirviön terveys" + hirvio2.terveys);
                             
                             }*/