using System;
namespace NoppaPeli
{
    public class Pelaaja : INimi
    {
        public string Nimi{ get; }
        public int Pisteet { get; set; }

        public Pelaaja(string nimi)
        {
            Nimi = nimi;
            Pisteet = 0;
        }
    }
}
