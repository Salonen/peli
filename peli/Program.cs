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
            string liike ="0";
            ///stopwatch = Stopwatch.StartNew();

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
                    case "1": Console.WriteLine("Pqqq"); break;
                    case "2": Console.WriteLine("Iqqq"); break;
                    case "3": Console.WriteLine("Eqqq"); break;
                    case "4": Console.WriteLine("Lqqq"); break;
                    //default : Console.Clear(); break;
                }

                ///Console.Clear();
                //Console.Read();
                //Console.Clear();
                //switch()

            }
        }
    }

    class hahmo
        {
            int voima, nopeus, terveys;
        }
}
