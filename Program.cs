using System;
using System.Threading.Channels;

namespace NameControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //programm küsib nime
            //kui siséstasid nime, siis konsool vastab
            //TERE, sinu nimi
            //peab kasutama if ja else
            //kui nime ei sisetata, siis tuleb vastuseks
            //ERROR ja konsool teeb Beep kolm korda


            Console.WriteLine("Sisetaja enda nimi ja vajuta´enter");
            string name = Console.ReadLine();

            if (name !== "")
            {
                Console.WriteLine("TEre " + name);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.Beep()
                Console.Beep()
                Console.Beep()
            }
        }
    }

}