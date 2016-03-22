using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace peli
{
    public partial class Program
    {
       /* hahmo pelaaja;
        hahmo hirvio; // ESITTELY !!

        pelaaja = new hahmo();
        hirvio = new hahmo();*/

       /* private void joo ()
        {
            pelaaja.Ase = 0;
        }*/

        static void Main(string[] args)
        {
            string liike ="0",liike2="2";
            ///stopwatch = Stopwatch.StartNew();
            ///
            hahmo pelaaja,hirvio; // ESITTELY !!

            pelaaja = new hahmo();
            hirvio = new hahmo();

           // pelaaja = new hahmo();
            //hirvio = new hahmo();

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
                /*while (true)
                {
                    Console.WriteLine(rnd.Next(1, 3));
                }*/
                if (liike=="1" || liike == "2" || liike == "3" || liike == "4")
                {
                    switch (rnd.Next(0, 4))
                    {
                        case 0: Console.WriteLine("Ei mitään"); break;
                        case 1: Console.WriteLine("Kirves");
                                Console.WriteLine("Otatko kirveen? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Kirves);
                                liike2= Console.ReadLine();
                                switch (liike2)
                                {
                                case "1" : pelaaja.Kirves= rnd.Next(1,21);
                                           Console.WriteLine("Kirves on nyt : " + pelaaja.Kirves);
                                           break;
                                case "2" : break;
                                }
                                break;
                        case 2: Console.WriteLine("Miekka");
                                Console.WriteLine("Otatko miekan? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Miekka);
                                liike2 = Console.ReadLine();
                                switch (liike2)
                                {
                                    case "1":
                                        pelaaja.Miekka = rnd.Next(5, 16);
                                        Console.WriteLine("Miekka on nyt : " + pelaaja.Miekka);
                                        break;
                                    case "2": break;
                                }
                                break;
                        case 3:
                            Console.WriteLine("Hirviö!");
                            Console.WriteLine("Hyökkää 1. Pakene 2.");
                            liike2 = Console.ReadLine();
                            switch (liike2)
                            {
                                case "1":
                                    switch (pelaaja.Ase)
                                    {
                                        case 1: hirvio.Terveys -= rnd.Next(0, pelaaja.Kirves); break;
                                        case 2: hirvio.Terveys -= rnd.Next(0, pelaaja.Miekka); break;
                                    }
                                    switch (hirvio.Ase) // ylimääräiset pois x 2
                                    { 
                                        case 1: pelaaja.Terveys -= rnd.Next(0, hirvio.Kirves); break;
                                        case 2: pelaaja.Terveys -= rnd.Next(0, hirvio.Miekka); break;
                                    }
                                    if (hirvio.Terveys <= 0)
                                    {
                                        Console.WriteLine("Voitit hirviön");
                                        hirvio.Terveys = 100;
                                    }
                                    if (pelaaja.Terveys <= 0)
                                    {
                                        Console.WriteLine("Hirviö voitti sinut");
                                        pelaaja.Terveys = 100;
                                    }
                                    break;
                                case "2":
                                    hirvio.Kirves = rnd.Next(1, 21);
                                    hirvio.Miekka = rnd.Next(1, 21);
                                    hirvio.Ase = rnd.Next(1, 3);
                                    Console.WriteLine("Hirviön ase " + hirvio.Ase);
                                    pelaaja.Terveys -= (hirvio.Kirves + hirvio.Miekka) / 2;
                                    break;
                            }
                            Console.WriteLine("Hirviön terveys" + hirvio.Terveys);
                            Console.WriteLine("Pelaajan terveys" + pelaaja.Terveys);
                            // pelaaja.Ase = 1;
                            //joo(pelaaja);
                            //taistelu(liike2);
                            break;
                    }
                }
            //Console.WriteLine("Hirviön terveys" + hirvio.Terveys);
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
            this.ase = 1;
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
        public int Terveys
        {
            get { return terveys; }
            set { terveys = value; }
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