using System;
namespace Tuotteet
{
    class Tuote : INimi, IId
    {
        //Kenttamuuttujat
        private double _hinta;
        //Ominaisuudet
        public int Id { get; }
        public string Nimi { get; set; }
        public Verokanta AlvKanta { get; set; }
        double Hinta
        {
            get { return _hinta; }
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Hinta ei voi olla negatiivinen.");
                }
                _hinta = Math.Round(value, 2);
            }
        }
        double VerollinenHinta
        {
            get
            {
                if (AlvKanta != null) {
                    return Math.Round(AlvKanta.Verokerroin * Hinta, 2);
                }
                return Hinta;
            }
        }
                     
        public Tuoteryhma Ryhma { get; set; }


        public Tuote(int id, string nimi, double hinta=0)
        {

            Id = id;
            Nimi = nimi;
            Hinta = hinta;
           
        }

        public override string ToString()
        {

            return ($"{Id} " + $"{Nimi}" + $" {VerollinenHinta}" + $" {(AlvKanta!=null?AlvKanta.Nimi:"")} ");

        }

    }
}
