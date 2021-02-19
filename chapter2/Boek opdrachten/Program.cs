using System;
// Opdracht 12 Geen idee ???????????
namespace Boek_opdrachten
{
    class Program
    {
        static void Main(string[] args)

        {
            // Opdrachten 1 t/m 8
            /* int getal = 1;
            long langGetal = 42965905;
            string tekst = "saai stukje tekst";
            Console.WriteLine($"Het getal heeft de waarde {getal} en de tekst is '{tekst}' het lange getal is '{langGetal}' "); 
            // "$" zorgt er voor dat je variablen op kan roepen tussen brackets "{ }"
            HoeveelCentimeter(getal); */

            //Opdracht 8
            VerliesGegevens();
            Console.WriteLine("Voer een getal in:");
            string invoer = Console.ReadLine();
            //float inch = Single.Parse(invoer); //Parse veranderd de variable naar het gene wat gevraagd word
            float inch = 0;
            var gelukt = Single.TryParse(invoer, out inch);
            var centimeter = HoeveelCentimeter(inch);
            Console.WriteLine($"Er gaat {centimeter} cm in {inch} inch");
            // De Main bevat nu 6 expressies "Invoer, VerliesGegevens, Gelukt, Centimeter, Inch en HoeveelCentimeter"

            //Opdracht 11
            float bedrag = 10;
            var btw = HoeveelBTW(bedrag, BtwPercentage.Laag); // .Laag kan vervangen worden door "Verlegd of Hoog"
            Console.WriteLine(btw);

            //Opdracht 13
            ChooseDrink();
        }
        // Opdracht 7/8
        //static void HoeveelCentimeter(float inch)
        static float HoeveelCentimeter(float inch)
        {
            //de conversaiefactor voor inch naar centimeter zal nooit veranderen 
            const float centimeterPerInch = 2.54F;
            var centimeter = inch * centimeterPerInch; // Var Centimeter maakt centimeter een Float omdat het de float er boven moet uitrekenen
            Console.WriteLine($"Er gaat {centimeter} cm in {inch} inch");
            Console.WriteLine($"per inch zit er {centimeterPerInch} Centimeter ");

            // Opdracht 10 De Methode is een Expressie maar de aanroep niet.
            return centimeter; // Na het veranderen blijft het een expressie
        } 

        //Opdracht 9 Maak een coversie waardoor je gegevens verliest
        static void VerliesGegevens()
        {
            long grootGetal = 420;
            int kleinGetal = (int)grootGetal; // Door de cast "(int)" kunnen er gegevens verloren gaan
            Console.WriteLine(kleinGetal);
        }

        public enum BtwPercentage { Verlegd = 0, Laag = 9, Hoog = 21 }

        static float HoeveelBTW(float bedrag, BtwPercentage percentage)
        {
            float btw = bedrag / 100 * (int) percentage;
            return btw;
        }

        /// <summary>
        /// Rekent het aantal centimeters uit hoeveer er in een inch past
        /// </summary>
        /// <param name="inch">Aantal inch per string</param>

        //static void HoeveelCentimeter(string inch)
        //{
        //    //de conversaiefactor voor inch naar centimeter zal nooit veranderen 
        //    const float centimeterPerInch = 2.54F;
        //    var centimeter = Convert.ToInt32(inch) * centimeterPerInch;
        //    Console.WriteLine($"Er gaat {centimeter} cm in {inch} inch");
        //    Console.WriteLine($"per inch zit er {centimeterPerInch} Centimeter ");
        //}

        //opdracht 13/14
        static void ChooseDrink()
        {
            String[] drinks = new string[3];
            drinks[0] = "Cola";
            drinks[1] = "Fanta";
            drinks[2] = "Ice tea";
            drinks[3] = "Bier";

            Console.WriteLine($"Vandaag wil ik graag {drinks}");

        }





        // einde programma
    }
    

}
