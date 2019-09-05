using System;
namespace Tuotteet
{
    public class Verokanta: INimi
    {
        //Kenttamuuttujat
        private int _veroprosentti;
        //Ominaisuudet
        public string Nimi { get; set; }
        public int Veroprosentti
        {
            get { return Veroprosentti; }
            set
            {
                if ((_veroprosentti < 0) || (_veroprosentti > 100))
                {
                    throw new Exception("Veroprosentin on oltava valilta 0-100.");

                }

                _veroprosentti = value;

            }
        }
        public double Verokerroin { get { return (Veroprosentti * 100) + 1; } }

        public Verokanta(int prosentti, string nimi)
        {
            Nimi = nimi;
            _veroprosentti = prosentti;
        }

        public override string ToString()
        { 
            return $"{Veroprosentti}" + " %" ;
          }
    }
}
