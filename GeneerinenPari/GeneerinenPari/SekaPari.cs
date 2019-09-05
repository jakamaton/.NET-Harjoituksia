using System;
namespace GeneerinenPari
{
    public class SekaPari<T, U>: ISekaPari<T, U>
    {
       public T A { get; set; }
       public  U B { get; set; }

        public SekaPari(T parametri1, U parametri2)
        {
            A = parametri1;
            B = parametri2;
        }

        public override string ToString()
        {

            return $"[{A}],[{B}]";
        }
    }
}
