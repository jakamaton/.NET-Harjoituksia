using System;
using static Helpers.Syote;
namespace NoppaPeli
{
    public static class Sovellus
    {
        static string nimi;
        static int VOITONPISTERAJA = 3;
       
       
       public static void Aja() {

            Pelaaja p1, p2;
            Console.WriteLine("Pelaajan 1 nimi:");
            nimi = Console.ReadLine();
            p1 = new Pelaaja(nimi);
            Console.WriteLine("Pelaajan 2 nimi:");
            nimi = Console.ReadLine();
            p2 = new Pelaaja(nimi);

            Noppa n1, n2;

            n1 = new Noppa();//naiden kaytto ei onnistunut
            n2 = new Noppa();

            for (int i = 1; i < 100; i++) {

                Console.WriteLine("Heittokierros: "+i);
                int heitto1 = Noppa.Heita();
                int heitto2 = Noppa.Heita();
                int tulo = heitto1 + heitto2;

                Console.WriteLine(p1.Nimi+" pisteet: "+heitto1+" + "+heitto2+" = "+tulo);
                 heitto1 = Noppa.Heita();
                 heitto2 = Noppa.Heita();
                int tulo2 = heitto1 + heitto2;

                Console.WriteLine(p2.Nimi + " pisteet: " + heitto1 + " + " + heitto2 + " = " + tulo2);
                if (tulo > tulo2) {

                    p1.Pisteet++;
                    p2.Pisteet = 0;
                    if (p1.Pisteet == VOITONPISTERAJA) {
                        Console.WriteLine("Pelinvoittaja on " + p1.Nimi + " ja noppia heitettiin" + i + " kertaa!");
                        i =100;
                    }

                }

                if (tulo2 > tulo) {

                    p2.Pisteet++;
                    p1.Pisteet = 0;
                    if (p2.Pisteet == VOITONPISTERAJA)
                    {
                        Console.WriteLine("Pelinvoittaja on "+p2.Nimi+" ja noppia heitettiin "+i+" kertaa!");
                        i = 100;
                    }
                }

            }



        }

    }
}
