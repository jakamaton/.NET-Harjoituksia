using System;

namespace NoppaPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sovellus.Aja();
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
    }
}
