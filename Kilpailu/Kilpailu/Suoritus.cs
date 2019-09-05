using System;
namespace Kilpailu
{
    public class Suoritus<T,U>
        // Geneerinenluokka Suoritus. Sisaltaa kaksi tyyppi parametria.
    {
       public T Osallistuja { get; set; }
        // Ensimmainen tyyppi parametri maarittaa automaattisen ominaisuuden Osallistuja.
       public U OsallistujanTulos { get; set; }
        // Toinen tyyppi parametri maarittaa automaattisen ominaisuuden OsallistujanTulos.

    }
}
