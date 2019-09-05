using System;
namespace Kilpailu
{
    public class Joukkue : IOsallistuja
        //Joukkue luokka toteuttaa IOsallistuja rajapinnan.
    {
        public string Nimi { get; set; }
        //Automaattinen ominaisuus Nimi.
        public int Id { get; set; }
        //Automaattinen ominaisuus Id.

    }
}
