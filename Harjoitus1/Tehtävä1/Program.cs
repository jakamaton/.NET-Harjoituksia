using System;
using System.Collections.Generic;
using System.Linq;

namespace Tehtävä1
{
    class Program
    {
        //Tahan lisataan esineita
        public static Laatikko laatikko;
        static void Main(string[] args)
        {
            //Vikasietoinen toteutus
            try
            {
                Console.WriteLine("Tehdään laatikot");
                Algoritmi();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ohjelman suoritus päättyi virheeseen. ");
                Console.WriteLine($"Virhe: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Paina Enter lopettaaksesi...");
                Console.ReadLine();
            }
        }

        public static void Algoritmi()
        {
            //Muuttujat joilla ilmoitetaan painavimman esineen nimi
            double Painavin = 0;
            string Nimi = "Painavin Nimi";
            //Muuttuja jonka avulla kerrotaan esineiden lukumaara
            int lkm = 0;
            //Esine olio jota kaytetaan myohemmin
            Esine esine;
            //Esine olion ominaisuuksien arvot pyydetaan naihin kahteen muuttujaan
            String EsineenNimi;
            double EsineenPaino;
            Console.WriteLine("Anna laatikon nimi (tyhjä lopettaa):");
            //Luodaan laatikko joka maariteltiin luokassa
            laatikko = new Laatikko(Console.ReadLine());
            //Jos laatikon nimen pituus on enemman kuin nolla merkkia aloitetaan toimintojen toisto
            if (laatikko.Nimi.Length>0) { 
                //Do lause jonka sisalla on kaikki ohjelman toiminnot
                do
                {
                    //Kysytaan kayttajalta tietoa
                    Console.WriteLine("Lisätään laatikkoon esineitä");
                    Console.WriteLine("Anna esineen nimi (tyhjä lopettaa): ");
                    EsineenNimi = Console.ReadLine();
                    //Varmistetaan etta tiedot ovat sopivia
                    if (EsineenNimi == "")
                    {
                        //Jos tiedot eivat ole sopivia tulostetaan ohjeissa maaritetyt asiat ja lopetetaan ohjelma
                        Console.WriteLine("Laatikkko " + laatikko.Nimi + " " + laatikko.maara + " kg");
                        Console.WriteLine("Esineita " + lkm + " kpl");
                        Console.WriteLine("Painavin esine " + Nimi + " " + laatikko.painavin + " kg");
                        return;
                    }
                    Console.WriteLine("Anna esineen paino (tyhjä lopettaa): ");
                    EsineenPaino = Convert.ToDouble(Console.ReadLine());
                    //Varmistetaan etta tiedot ovat sopivia
                    if (EsineenPaino == 0)
                    {
                        //Jos tiedot eivat ole sopivia tulostetaan ohjeissa maaritetyt asiat ja lopetetaan ohjelma
                        Console.WriteLine("Laatikkko " + laatikko.Nimi + " " + laatikko.maara + " kg");
                        Console.WriteLine("Esineita " + lkm + " kpl");
                        Console.WriteLine("Painavin esine " + Nimi + " " + laatikko.painavin + " kg");
                        return;
                    }
                    //Tassa pidetaan muistissa painavimman esineen nimi
                    if (EsineenPaino > Painavin)
                    {
                        Nimi = EsineenNimi;
                        Painavin = EsineenPaino;
                    }
                    //Luodaan Esine olio kayttajan antamilla tiedoilla
                    esine = new Esine(EsineenNimi, EsineenPaino);
                    //Kuinka monta esinetta lisataan
                    Console.WriteLine("Lisättävä määrä (tyhjä lopettaa): ");
                    int lisaa = Convert.ToInt32(Console.ReadLine());
                    //Tassa pidetaan lukua siita kuinka monta Esine oliota on lisatty
                    lkm += lisaa;
                    //Jos ei lisata yhtaan tai esineen paino kertaa se maara kuinka monta niita olisi tarkoitus lisata ylittaa laatikon maksimipainon lopetetaan ohjelman suoritus
                    if (lisaa > 0 && ((lisaa*EsineenPaino)+laatikko.maara)<laatikko.maksimipaino)
                    {
                        //Lisataan esineita ja tulostetaan mita lisattiin ja kuinka monta
                        for (int x = 0; x < lisaa; x++)
                        {
                            laatikko.LisaaEsine(esine);
                        }
                        Console.WriteLine("Esinettä " + EsineenNimi + " lisättiin: " + lisaa + " kappaletta");
                    }
                    else
                    { //Jos tiedot eivat ole sopivia tulostetaan ohjeissa maaritetyt asiat ja lopetetaan ohjelma
                        //Esineiden kokonaismaarasta otetaan myos pois ne mita sinne ei lisatty koska maksimipaino ylittyi sen jalkeen se ilmoitetaan kayttajalle ja tulostetaan muut tiedot
                        double ylitys = ((lisaa * EsineenPaino) + laatikko.maara) - laatikko.maksimipaino;
                        int turha = Convert.ToInt32(ylitys);
                        lisaa -= turha;
                        lkm -= lisaa;
                        for (int x = 0; x < lisaa; x++)
                        {
                            laatikko.LisaaEsine(esine);
                        }
                        Console.WriteLine("Viimeinen lisays tuotti "+ylitys+" kilon maksimipainon ylityksen, joten "+ EsineenNimi+" lisattiin vain "+ lisaa+" kpl");
                        Console.WriteLine("Laatikkko " + laatikko.Nimi + " " + laatikko.maara + " kg");
                        Console.WriteLine("Esineita "+ lkm+" kpl");
                        Console.WriteLine("Painavin esine " + Nimi + " " + laatikko.painavin + " kg");
                            return;
                    }
                } while (EsineenNimi != "" || EsineenPaino > 0);
            }
        }
    }
}


