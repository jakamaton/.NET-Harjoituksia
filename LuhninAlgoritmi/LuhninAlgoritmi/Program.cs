using System;

namespace LuhninAlgoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arvoja joita ohjelmassa kaytetaan
            int virhe = 0;
            int onnistunut = 0;
            string teksti = "";
            //Metodi joka kysyy syotteen
            Kysy(teksti, virhe, onnistunut);

        }

        static public void Kysy(string teksti, int virhe, int onnistunut)
        {

            Console.WriteLine("Anna numerosarja, tyhja lopettaa");
            teksti = Console.ReadLine();

            //Jos syote on tyhja lopetetaan
            if (teksti == "")
            {
                Console.WriteLine("Onnistuneiden syotteiden maara: " + onnistunut);
                Console.WriteLine("Epaonnistuneiden syotteiden maara: " + virhe);
                Environment.Exit(0);
            }
            //Kaannetaan teksti numerosarjaksi ja asetetaan numerosarja sen jalkeen tekstin arvoksi
            long numerosarja;
            long.TryParse(teksti, out numerosarja);
            teksti = numerosarja.ToString();

            //Jos teksti ei ole sopiva se kerrotaan kayttajalle ja metodi aloitetaan alusta
            if (teksti == "0")
            {
                //Lisataan virhe muuttujan arvoa joka tulostetaan ohjelman lopussa
                virhe++;
                Console.WriteLine("Syote ei ole numerosarja");
                Kysy(teksti, virhe, onnistunut);
            }
            //Jos teksti on sellainen kuin sen pitaa olla se lahetetaan tarkistus metodiin
            else
            Luhn(teksti, onnistunut, virhe);
            //Tarkistus metodi antaa vastauksen oliko luku Luhnin algoritmin mukainen
            //Jos oli siitä ilmoitetaan ja ensimmainen metodi kaynnistyy uudestaan
            if (Luhn(teksti, onnistunut, virhe))
            {
                Console.WriteLine("Syote on kelvollinen");
                //Lisataan onnistunut suoritus 
                onnistunut++;
                Kysy(teksti, virhe, onnistunut);
            }
            //Jos syote ei ole kelvollinen siita ilmoitetaan ja metodi kaynnistetaan uudestaan
            else
            {
                Console.WriteLine("Syote ei ole kelvollinen");
                //lisataab virhe
                virhe++;
                Kysy(teksti, virhe, onnistunut);
            }


        }
        //Metodi joka tarkistaa onko numerosarja algoritmin mukainen, palauttaa totuus arvon
        static bool Luhn(string teksti, int onnistunut, int virhe)
        {
            {
                //muuttuja jota kaytetaan summan laskemiseen ja totuus arvo jonka avulla tunnistetaan joka toinen numero
                int summa = 0;
                bool parillinen = false;
                //Lasketaan algoritmin mukaisesti pois lukien viimeinen numero
                for (int i = 0; i<teksti.Length-1; i++)
                {
                    //Otetaan tekstista i arvo
                    int luku = teksti[i]-'0';

                    //Jos luku on parillinen se kerrotaan kahdella
                    if (parillinen == true)
                        luku = luku * 2;
                    //Lisataan luku summa muuttujaan
                    summa += luku % 10;
                    //Vaihdetaan parillisen arvo
                    parillinen = !parillinen;
                }
                //Tassa otetaan tarkistusnumero tyyppeja vaihtelemalla
                int viimeinen = teksti.Length-1;
                var numero= teksti.Substring(viimeinen);
                int tarkistusnumero;
                int.TryParse(numero, out tarkistusnumero);
                //Lopuksi lisataan tarkistusnumero summaan ja tulos jaetaan kymmenella ja palautetaan.
                return ((summa+tarkistusnumero) % 10 == 0);
            }

        }

    }
}
