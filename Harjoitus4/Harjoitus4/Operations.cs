using System;
namespace Harjoitus4
{
    public class Operation
    {
        public int Id { get; set; }
        public int TotalTimeInSeconds { get; set; }
        public int SpendTimeInSeconds { get; set; }
        public int Breaks { get; set; }
        public DateTime Started { get; set; }
        public DateTime Ended { get; set; }

        public Operation()
        {
            Started = DateTime.Now;
        }

        public void Print()
        {

            System.Console.SetCursorPosition(0, Id);
            Console.WriteLine($"{Id} { Started.ToLongDateString() } {SpendTimeInSeconds / TotalTimeInSeconds*100}%");
            System.Console.SetCursorPosition(0, Id);
        }

        public void PrintEnded()
        {
            System.Console.SetCursorPosition(0, Id);
            Console.WriteLine($"{Id } { Started.ToLongDateString()} {" - "}+{Ended.ToLongTimeString()} {" = "} {(Started - Ended).Seconds}");
            System.Console.SetCursorPosition(0, Id);
        }
    }
}
