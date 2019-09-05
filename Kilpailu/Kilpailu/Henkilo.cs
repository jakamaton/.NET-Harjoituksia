using System;
namespace Kilpailu
{
    public class Henkilo : IOsallistuja
    {
        //Luokka Henkilo toteuttaa rajapinnan IOsallistuja.
        public int Id { get; set; }
        //Automaattinen ominaisuus Id.
        string Etunimi { get; set; }
        //Automaattinen ominaisuus Etunimi.
        string Sukunimi { get; set; }
        //Automaattinen ominaisuus Sukunimi.
        public string Nimi { get { return Etunimi + " " + Sukunimi; }
            // Maaritellaan automaattinen ominaisuus Nimi,jonka get metodilla
            // palautetaan automaattisen ominaisuuden Etunimi ja Sukunimi
            // arvot valilyonnilla erotettuna.
            set
            { string[] Nimet = value.Split(' ');
                if (Nimet.Length == 2)
                {
                    Etunimi = Nimet[0];
                    Sukunimi = Nimet[1];
                }
                else {
                    throw new Exception("Henkilön nimi on oltava muodossa sukunimi etunimi.");
                }
            } }
        // Automaattisen ominaisuuden set metodissa asetetaan Nimi muuttujan arvoksi
        //kaksi merkkijonoa, joiden valissa on valilyonti. Muuten ilmoitetaan virheelisesta
        // syotteesta.


    }
}
