using System;
using System.Linq;

namespace LINQ_cd
{
    class Program
    {
        static void Main(string[] args)
        {
            string times = Console.ReadLine();

            if(times.Length == 0)
            {
                Console.WriteLine();
                return;
            }

            var splitted = times.Split(',');
            int count = splitted.Count();

            var query = splitted
                .Select(s => s.Split(':'))
                .Select(s => (int.Parse(s[0]) * 60) + int.Parse(s[1]));

            double timestamp = query.Sum();
            double averageInSeconds = query.Average();

            //

            short minutes = (short) Math.Floor(averageInSeconds / 60);
            short seconds = (short) Math.Ceiling((averageInSeconds - (minutes * 60)));

            short tHours = (short) Math.Floor((timestamp / 3600) % 24);
            short tMinutes = (short) Math.Floor((timestamp / 60) % 60);
            short tSeconds = (short) Math.Ceiling(timestamp % 60);

            if(tHours > 0)
            {
                Console.WriteLine($"{count} {minutes:D0}:{seconds:D2} {tHours:D0}:{tMinutes:D2}:{tSeconds:D2}");
            } 
            else
            {
                Console.WriteLine($"{count} {minutes:D0}:{seconds:D2} {tMinutes:D0}:{tSeconds:D2}");
            }
            
        }
    }
}
