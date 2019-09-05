using System;
using static System.Console;
using static Helpers.Syote;
namespace Tuotteet 
{ 

class Program { 
   
        static void Main(string[] args)
        {

            try
            {
                Algoritmi();
            }
            catch (Exception e)
            {
                WriteLine($"Ohjelman suorituksessa tuli virhe: {e.Message}");
            }
            finally
            {
                Write("Paina Enter lopettaaksesi");
                ReadLine();
            }

        }


        static void Algoritmi()
        {

            Verokanta k1, k2, k3, k4;

            k1 = new Verokanta(0, "ALV0%");

            k2 = new Verokanta(10, "ALV10%");

            k3 = new Verokanta(14, "ALV14%");

            k4 = new Verokanta(24, "ALV24%");


            Tuoteryhma r1, r2;
            r1 = new Tuoteryhma(1, "tuoteryhma1");
            r2 = new Tuoteryhma(2, "tuoteryhma2");



            Tuote t1, t2;

            t1 = new Tuote(3, "Tuote1", 25) {
                Ryhma = r1,
                AlvKanta = k3,
            };

            t2 = new Tuote(4, "toinen",90);
            WriteLine(t1 + r1.Nimi);

        }



}
}
