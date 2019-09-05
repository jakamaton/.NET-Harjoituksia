using System;
namespace Tuotteet
{
    class Tuoteryhma : IId, INimi {
       
        //Ominaisuudet
        public int Id { get;}
        public string Nimi { get; set; }

        public Tuoteryhma(int id, string nimi)
       
         {
            Id = id;
            Nimi= nimi;
        }

        public override string ToString()
        {
            return ($"{Id} "+$" {Nimi}");
        }

    }
}
