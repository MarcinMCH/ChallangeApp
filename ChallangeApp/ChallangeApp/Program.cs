using ChallangeApp;
using System;

//var emploee = new Emploee("Marcin", "Chmara");
//emploee.AddGrades(5);
//emploee.AddGrades(2);
//emploee.AddGrades("8.0");
//emploee.AddGrades('B');
//emploee.AddGrades(6);

//var statistic = emploee.GetStatistic();

//Console.WriteLine($"Average: {statistic.Average:n2}");
//Console.WriteLine($"Max: {statistic.Max}");
//Console.WriteLine($"Min: {statistic.Min}");
//Console.WriteLine($"Average Latter: {statistic.AvarageLetter}");

Console.WriteLine("Witaj w programie XYZ do oceny Pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("Podaj pierwszą ocenę Pracownika:");

var emploee = new Emploee("Marcin", "Chmara");

do
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    emploee.AddGrades(input);
    Console.WriteLine("Podaj kolejną ocenę Pracownika");

} while (true);

var statistic = emploee.GetStatistic();
Console.WriteLine($"Średnia: {statistic.Average}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Ocena: {statistic.Average}");


//var statistic = emploee.GetStatistic();
//Console.WriteLine(statistic.Average);
