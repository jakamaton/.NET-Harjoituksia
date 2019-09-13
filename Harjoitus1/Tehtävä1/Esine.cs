using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä1
{
    class Esine : INimi, IComparable<Esine>
    {
        //Luokka Esine toteuttaa rajapinnat INimi ja IComparable
        //Luokassa on ominaisuus Paino joka on desimaaliluku
        public String Nimi { set; get; }
        public double Paino { get; set; }
        //Tassa on luultavasti joku virhe koska se vaikuttaa turhalta
        public double PainoG { get { return Paino; } }

        //Konstrukstori jossa asetetaan arvot
        public Esine(String nimi, double paino) {

            this.Nimi=nimi;
            if (paino < 0)
            {
                throw new Exception("Painon ei saa olla negatiivinen");
            }
            else 
                //Paino grammoina
                Math.Round(paino, 3);
                this.Paino = paino;
        }

        //ToStrin Metodi joka ylikirjoittaa automaattisen ToString Metodin
        public override string ToString()
        {
            return ($"{Nimi} {PainoG}");
        }

        //CompareTo metodi en tiennyt mita silla olisi pitanyt tehda mutta siina se on
        public int CompareTo(Esine Olio)
        {
            return this.Paino.CompareTo(Olio.Paino);
        }

    }
}
