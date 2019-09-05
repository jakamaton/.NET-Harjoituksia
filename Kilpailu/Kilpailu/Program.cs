using System;
using static System.Console;

namespace Kilpailu
{
    class Program
    {
        public static Random rnd = new Random();
        // Luodaan random olio
        static void Main(string[] args)
        {
            // Toteutetaan ohjelma vikasietoisesti niin, että virheet tulostetaan naytolle
            // Lopuksi tulostetaan teksti "Paina Enter lopettaaksesi" ja luetaan
            // Enter nappaimen painallus.
            try
            {
                Algoritmi();

            }
            catch (Exception e)
            {
                WriteLine($"Virhe: {e.Message}");
            }
            finally
            {
                Write("Paina Enter lopettaaksesi");
                ReadLine();
            }

        }

       public static void Algoritmi() {
            //Algoritmissa kysytaan kayttajalta minkalaisen kilpailun han haluaa, Yksilo vai Joukkue (Tyhja lopettaa).
            // Annetaan ohjeet kolmen vaihtoehdon toteuttamiseen.
            WriteLine("Tehdaanko yksilo- (y) vai joukkuekilpailu (j), tyhja lopettaa: ");
            string muuttuja = ReadLine();
            // Otetaan kayttajan syote talteen. Sen perusteella maaritetaan mihin metodiin siirrytaan.
            if (muuttuja == "y") {
                Yksilo();
            }

            if (muuttuja == "j") {
                Joukkue();
            }

        }

        public static void Yksilo() {
            // Kayttaja halusi luoda yksinpelin. Luodaan uusi yksinpeli-olio.
            YksiloKilpailu kilpailu = new YksiloKilpailu();
            double minimi;
            WriteLine("Anna yksilokilpailun minitulos: ");
            minimi = Convert.ToDouble(Console.ReadLine());
            // Kysytaan kayttajalta minimi pistemaara, jota kilpailussa kaytetaan.
            double maksimi;
            WriteLine("Anna yksilokilpailun maksimitulos: ");
            maksimi = Convert.ToDouble(Console.ReadLine());
            // Kysytaan kayttajalta maksimi pistemaara, jota kilpailussa kaytetaan.
            string kilpailun_nimi;
            WriteLine("Anna yksilokilpailun nimi: ");
            kilpailun_nimi = ReadLine();
            // Kysytaan kilpailun nimi.
            kilpailu.Nimi = kilpailun_nimi;
            // Asetetaan se kilpailu-olion Nimi kentan arvoksi.
            WriteLine("Anna osallistujan nimi muodossa sukunimi etunimi (tyhja lopettaa): ");
            string nimi = ReadLine();
            // Kysytaan kayttajalta kilpailijan nimi. Muodossa "Sukunimi ja Etunimi".
            do
            {
                Henkilo henkilo = new Henkilo() {
                    Nimi = nimi,
                };
                // Luodaan uusi Henkilo-olio ja asetetaan kayttajalta saatu nimi Henkilo-olion Nimi kentan arvoksi.

                Suoritus<Henkilo, double> olio = new Suoritus<Henkilo, double>
                {
                    Osallistuja = henkilo,
                    OsallistujanTulos = rnd.NextDouble() * (maksimi - minimi) + minimi
            };
                //Luodaan uusi Suoritus-olio. Asetetaan sille ominaisuudet.
                kilpailu.Suoritukset.Add(olio);
                // Lisataan Suoritus olio kilpailu-olion Suoritukset ominaisuuteen.

                WriteLine("Anna osallistujan nimi muodossa sukunimi etunimi (tyhja lopettaa): ");
                nimi = ReadLine();
                // Kysytaan seuraavan kilpailijan nimi

            } while (nimi != "");
            // Edellista toistetaan kunnes kayttaja ei anna uutta nimea

            WriteLine($"Kilpailun {kilpailun_nimi} tulokset: ");
            foreach (Suoritus<Henkilo, double> s in kilpailu.Suoritukset)
            {
                WriteLine(s.Osallistuja.Nimi + ", " + Math.Round(s.OsallistujanTulos, 2));
            }
            // Kun toisto on lopetettu tulostetaan jokaisen Suoritus-olion osallistuja nimi
            // ja osallistujan tulos kahden desimaalin tarkkuudella.

            Algoritmi();
            // Aloitetaan alusta.
        }


        public static void Joukkue() {
            // Kayttaja halusi luoda joukkuepelin. Luodaan uusi joukkuepeli-olio.
            JoukkueKilpailu kilpailu = new JoukkueKilpailu();
            int maksimi;
            WriteLine("Anna joukkuekilpailun maksimitulos");
            maksimi = Convert.ToInt32(Console.ReadLine());
            // Kysytaan kayttajalta maksimi pistemaara, jota kilpailussa kaytetaan.
            string kilpailun_nimi;
            WriteLine("Anna joukkuekilpailun nimi:");
            kilpailun_nimi = ReadLine();
            // Kysytaan kilpailun nimi.
            kilpailu.Nimi = kilpailun_nimi;
            // Asetetaan se kilpailu-olion nimeksi.
            WriteLine("Anna osallistujan nimi (tyhja lopettaa): ");
            string nimi = ReadLine();
            // Kysytaan kayttajalta osallistujan nimi.
            do
            {
               Joukkue joukkue = new Joukkue()
                {
                    Nimi = nimi,
                };
                // Luodaan uusi Joukkue-olio ja asetetaan kayttajalta saatu nimi sen nimi kentan arvoksi.
                Suoritus<Joukkue, int> olio = new Suoritus<Joukkue, int>
                {
                    Osallistuja = joukkue,
                    OsallistujanTulos = rnd.Next(0, maksimi)
                };
                //Luodaan uusi Suoritus-olio. Asetetaan sille ominaisuudet.
                kilpailu.Suoritukset.Add(olio);
                // Lisataan Suoritus olio kilpailu-olion Suoritukset ominaisuuteen.
                WriteLine("Anna osallistujan nimi (tyhja lopettaa): ");
                nimi = ReadLine();
                // Kysytaan seuraavan kilpailijan nimi.
            } while (nimi != "");
            // Edellista toistetaan kunnes kayttaja ei anna uutta nimea.
            WriteLine($"Kilpailun {kilpailun_nimi} tulokset: ");
            foreach (Suoritus<Joukkue, int> j in kilpailu.Suoritukset)
            {
                WriteLine(j.Osallistuja.Nimi + ", " + j.OsallistujanTulos);
            }
            // Kun toisto on lopetettu tulostetaan jokaisen Suoritus-olion osallistuja nimi ja tulos.
            Algoritmi();
            // Aloitetaan alusta, jos kayttaja haluaa luoda uuden kilpailun.
        }
    }
}
