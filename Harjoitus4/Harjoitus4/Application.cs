using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Harjoitus4
{
    public class Application
    {
        public static int LastOperationId;
        public static List<Operation> Operations = new List<Operation>();
        public static Random r = new Random();
        public static int MaxBreaks = 10;
        public static int MinTimeInSeconds = 5;
        public static int MaxTimeInSeconds = 10;

        static public void PrintOperations(List<Operation> parametri)
        {
            foreach (Operation objekti in parametri)
            {

                objekti.PrintEnded();
            }
        }

        public async static Task KaynnistaOperaatioAsync(Operation parametri)
        {
            int i=0;
            await Task.Run(() => {
                Thread.Sleep((int)((parametri.TotalTimeInSeconds * 1.0 / parametri.Breaks) * 1000));
                parametri.SpendTimeInSeconds = (int)(parametri.TotalTimeInSeconds * i * 1.0 / parametri.Breaks);
                parametri.Print();
            });
            parametri.Ended = DateTime.Now;
            return;
        }

        public static void Run()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.Write(" ");
            }
            System.Console.SetCursorPosition(0, 0);
            string s=" ";
            do
            {
                Console.WriteLine(" Kaynnista uusi operaatio = K, Lopeta ohjelma = L: ");
                s = Console.ReadLine();
                LastOperationId++;
                Operation operaatio = new Operation
                {
                    Id = LastOperationId,
                    Breaks = r.Next(1, MaxBreaks),
                    TotalTimeInSeconds = r.Next(MinTimeInSeconds, MaxTimeInSeconds)
                };
                Operations.Add(operaatio);
                KaynnistaOperaatioAsync(operaatio);
            } while (s == "K" || s == "k");

            if (s == "L" || s == "L")
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write(" ");
                }
                System.Console.SetCursorPosition(0, 0);
                Console.WriteLine("Paina Enter kun suoritus loppuu");
                PrintOperations(Operations);
                Console.ReadLine();
            }

        }
    }
}

