using System;
using System.Threading;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen,
            int intGetal, intTeller;
            int intAantal = 0;
            int intDeler = 1;

            //Anker instellen
            Start:

            //Opvragen van het getal in de console.
            Console.Write("Geef een getal in met een maximum van 100: ");
            intGetal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //weergave in de console.
            //Controle: getal moet kleiner dan of gelijk aan 100 zijn.
            if(intGetal <= 100)
            {
                for(intTeller = 1; intTeller <= intGetal; intTeller++)
                {
                    Console.Write(intTeller.ToString() + ": ");
                    intAantal = 0;

                    for(intDeler = 1; intDeler <= intTeller; intDeler++)
                    {
                        if(intTeller % intDeler == 0)
                        {
                            //Console.WriteLine();
                            Console.Write(intDeler.ToString() + ": ");

                            intAantal++;
                        }
                    }
                    //Als een getal deelbaar is door 1 en zichzelf (Dus 2 delers heeft), dan is het een priemgetal
                    if (intAantal == 2)
                    {
                        Console.Write("Priemgetal");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Druk op ENTER om de console aftesluiten");
            }
            else
            {
                Console.WriteLine("Foutief getal");
                Console.WriteLine();
                //Terug naar anker
                goto Start;
            }
        }
    }
}
