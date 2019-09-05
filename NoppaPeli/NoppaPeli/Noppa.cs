using System;
namespace NoppaPeli
{
    public class Noppa
    {
        public static Random Rnd = new Random();
        public static int Lukema { get; set; }
        public static int HeittoLkm {get; set;}


        static Noppa()
        {
            HeittoLkm = 0;
        }

            public static int Heita() {

            Lukema = Rnd.Next(1, 6);
            HeittoLkm++;
            return Lukema;
        }
    }
}
