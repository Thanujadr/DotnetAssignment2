// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
       
        Regex dateRegex = new Regex(@"(\d{2})(\d{2})(\d{4})");
        MatchCollection matches = dateRegex.Matches(input);

        foreach (Match match in matches)
        {
            string date = match.Value;
            string month = match.Groups[1].Value;
            string day = match.Groups[2].Value;
            string year = match.Groups[3].Value;
            Console.WriteLine($"Valid Date Found in given input : {date} (MMDDYYYY)");
            Console.WriteLine($"Day : {day}, Month : {month}, Year : {year}");
        }
    }
}
