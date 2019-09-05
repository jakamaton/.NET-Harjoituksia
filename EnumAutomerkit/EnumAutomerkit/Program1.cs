using System;

namespace EnumAutomerkit
{
    class Program
    {
        enum Automerkki {
            Audi = 100,
            BMW,
            Citroen,
            Mercedes_Benz,
            Skoda,
            Toyota,
            Volkswagen,
            Volvo
        }
        static void Main(string[] args)
        {
            //Tulostetaan Otsikko ja lista
            Console.WriteLine("AUTOMERKIT");
            for (int i = 100; i < 99 + Enum.GetNames(typeof(Automerkki)).Length; i++) {
                Automerkki am;
                am = (Automerkki)i;
                Console.WriteLine(i + $" {am}");
            }
            syoteNum();
        }

        public static void syoteNum()
        {
            int muuttuja = 0;
            string[] Merkit = System.Enum.GetNames(typeof(Automerkki));
            //Kysytaan kayttajalta minka "tiedon" han listalta haluaa
            string teksti = "";
            Console.WriteLine("Valitse automerkki joko numerolla tai nimellä (tyhja lopettaa)");
            teksti = Console.ReadLine();
            if (teksti == "")
            {
                return;
            }
            else { 
            for (int k = 0; k < Enum.GetNames(typeof(Automerkki)).Length; k++)
                {
                    if (teksti == "Mercedes-Benz")
                    {
                        teksti = "Mercedes_Benz";
                    }
                    if (teksti == Merkit[k])
                    {
                        //jos syote loytyy aloitetaan alusta
                        Console.WriteLine("Syotetta " + teksti + " vastaava arvo on Automerkki." + Merkit[k]);
                        muuttuja++;
                        syoteNum();
                    }
                    else if (k == Enum.GetNames(typeof(Automerkki)).Length - 1)
                    {
                        numeerinen(teksti, muuttuja);
                    }
                }
        }
        }

        public static void numeerinen(string teksti, int muuttuja)
        {
            Automerkki am;
            int.TryParse(teksti, out int i);
            foreach (int luku in Enum.GetValues(typeof(Automerkki)))
            {
                //jos listalla on jokin kayttajan syotetta vastaava arvo se sen numeerinen arvo ja "jokin arvo" tulostetaan
                if (i == luku)
                {
                    am = (Automerkki)i;
                    Console.WriteLine("Syotetta " + i + " vastaava arvo on Automerkki." + am);
                    muuttuja++;
                    //aloitetaan alusta
                    syoteNum();
                }
            }
            testi(teksti, muuttuja);
        }

        public static void testi(string teksti, int muuttuja)
        {

            if (teksti =="")
            {
                return;
            }
            if (muuttuja == 0) { 
            Console.WriteLine("Syotetta: " + teksti + " Vastaavaa arvoa ei loydy luettelosta");
                syoteNum();
        }
            else
            syoteNum();
        }

    }
    }

