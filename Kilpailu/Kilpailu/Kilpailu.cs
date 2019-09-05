using System;
using System.Collections.Generic;
namespace Kilpailu
{
    public class Kilpailu<T,U>
        // Geneerinenluokka, joka sisaltaa kaksi tyyppi parametria. Tyyppeja kaytetaan myos
        //Suoritus luokan tyyppitamiseen.
    {
        public string Nimi { get; set; }
        // Automaattinen ominaisuus Nimi.
        public List<Suoritus<T, U>> Suoritukset { get; set; }
        // Automaattinen ominaisuus, joka on tyypiltaan luokan tyyppiparametrein varustettu Suoritus olioiden lista.

        public Kilpailu()
            // Konstruktori, jossa Suoritukset arvoksi maaritetaan tyyppiparametrien
            // maaritelty Suoritus-olioiden lista.
        {
            Suoritukset = new List<Suoritus<T, U>>();
        }
    }
}
