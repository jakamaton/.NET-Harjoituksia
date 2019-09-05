using System;
namespace GeneerinenPari
{
    public class Pari<T>: IPari<T>
    {
       public T A { get; set; }
        public T B { get; set; }

        public Pari(T parametri1, T parametri2)
        {
            A = parametri1;
            B = parametri2;
        }

        public override string ToString() { 
        
            return $"[{A}],[{B}]";
        }
    }
}
