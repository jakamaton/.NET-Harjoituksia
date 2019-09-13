using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tehtävä1
{
    class Laatikko : INimi
        //Toteutetaan rajapinta INimi
    {
        // Ominaisuudet
        public String Nimi { get; set; }
        IList<Esine> esineet;
        public int maksimipaino;
        //Laatikko olion kokonaispaino ilmaistaan talla muuttujalla
       public double maara { get
            {
                double PainoSumma = 0;
                for (int i = 0; i<esineet.Count; i++) {
                    PainoSumma += esineet[i].Paino;
                }
                //Paino grammoina
                return Math.Round(PainoSumma, 3);
            } }
        //Laatikon painavin ilmaistaan talla muuttujalla
       public double painavin { get
            {
                double maxPaino =0;
                for (int j = 0; j<esineet.Count;j++)
                {
                    if (esineet[j].Paino > maxPaino)
                    {
                        maxPaino = esineet[j].Paino;
                    }
                }
                return Math.Round(maxPaino, 3);
            }
         }
        //Konstruktori jossa asetetaan arvot
        public Laatikko(string nimi, int paino = 100)
        {
            this.Nimi = nimi;
            maksimipaino = paino;
            esineet = new List<Esine>();
            
        }

        //Metodi jossa lisataan olioita listaan
        public void LisaaEsine(Esine olio)
        {
                esineet.Add(olio);
        }
        //ToStrin Metodi joka ylikirjoittaa automaattisen ToString Metodin
        public override string ToString()
        {
            return Nimi+" "+" "+ maara; 
        }
    }
}
