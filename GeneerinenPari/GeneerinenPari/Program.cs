using static Helpers.Syote;
using static System.Console;
using System;




namespace GeneerinenPari
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Algoritmi();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ohjelman suorituksessa tuli virhe: {e.Message}");
            }
            finally
            {
                Console.Write("Paina Enter lopettaaksesi");
                Console.ReadLine();
            }
        }

        static void Algoritmi() {

            int kokonaisluku = KokonaislukuPakottaen("Anna 1. kokonaisluku: ");
            int kokonaisluku1 = KokonaislukuPakottaen("Anna 2. toinen kokonaisluku: ");
            Pari<int> pari1 = new Pari<int> (kokonaisluku, kokonaisluku1);

            double desimaali = DesimaalilukuPakottaen("Anna desimaaliluku: ");
            SekaPari<Pari<int>, double> pari2 = new SekaPari<Pari<int>, double>(pari1, desimaali);

            string teksti = Merkkijono("Anna 1. merkkijono");
            string teksti1 = Merkkijono("Anna 2. toinen merkkijono");
            Pari<string> pari3 = new Pari<string>(teksti,teksti1);
            SekaPari<SekaPari<Pari<int>, double>, Pari<string>> pari4 = new SekaPari<SekaPari<Pari<int>, double>, Pari<string>>(pari2, pari3);

            WriteLine("Pari 1: "+pari1);
            WriteLine("Pari 2: "+pari2);
            WriteLine("Pari 3: "+pari3);
            WriteLine("Pari 4: "+pari4);
        }
    }
}
