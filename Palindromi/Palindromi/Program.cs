using System;

namespace Palindromi
{
    class Program
    {
        static public void suodatus(string teksti)
        {
            if (teksti == "")
            {
                return;
            }
            else {
                for (int j = 0; j < teksti.Length; j++)
                {
                    if (teksti[j] == ' ')
                    {
                        teksti = teksti.Remove(j, 1);
                        j--;
                    }
                    if (teksti[j] == '.')
                    {
                        teksti = teksti.Remove(j, 1);
                        j--;
                    }
                    if (teksti[j] == ',')
                    {
                       teksti = teksti.Remove(j, 1);
                        j--;
                    }
                    if (teksti[j] == ':')
                    {
                        teksti = teksti.Remove(j, 1);
                        j--;
                    }
                    if (teksti[j] == ';')
                    {
                        teksti = teksti.Remove(j, 1);
                        j--;
                    }
                    if (teksti[j] == '!')
                    {
                        teksti = teksti.Remove(j, 1);
                        j--;
                    }
                    if (teksti[j] == '?')
                    {
                        teksti = teksti.Remove(j, 1);
                        j--;
                    }
                }
                monistus(teksti);
            }
        }
        static public void monistus(string teksti)
        {
            int i = teksti.Length;
            char[] lista = new char[i];
            for (int j = 0; j < i; j++)
            {
                lista[j] = teksti[j];
            }

            char[] kopio = new char[i];
            Array.Copy(lista, 0, kopio, 0, i);
            Array.Reverse(kopio);
            vertailu(lista, kopio);
        }


        static public void vertailu(char[] lista, char[] kopio)
        {
            int i = lista.Length;
            int k = 0;
            for (int j=0; j < i; j++)
            {
                if (lista[j] == kopio[j]) {
                    k++;
                    if (k == i) {
                        Console.WriteLine("on palindromi");
                    }
                }
                if(j==i-1&&k<i-1) {
                    Console.WriteLine("ei ole palindromi");
                }

            }
            Console.WriteLine(" Anna teksti (tyhjä lopettaa): ");
            string teksti = Console.ReadLine();
            suodatus(teksti);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Anna teksti (tyhjä lopettaa): ");
            string teksti = Console.ReadLine();
            suodatus(teksti);
        }
    }
}
