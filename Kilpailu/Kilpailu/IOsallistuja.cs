using System;
namespace Kilpailu
{
    public interface IOsallistuja
    {
        //maaritellaan rajapinnan ominaisuudet.
        string Nimi { get; }
        int Id { get; }
    }
}
