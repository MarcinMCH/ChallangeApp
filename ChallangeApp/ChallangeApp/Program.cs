using ChallangeApp;
using System;

var emploee = new Emploee("Marcin", "Chmara");
emploee.AddGrades(5);
emploee.AddGrades(2);
emploee.AddGrades("8.0");

Console.WriteLine("FOR---------------------------------------");

var statistic = emploee.GetStatisticWithFor();

Console.WriteLine($"Average: {statistic.Average:n2}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");

Console.WriteLine("DOWHILE-----------------------------------");

var statistic2 = emploee.GetStatisticWithDoWhile();

Console.WriteLine($"Average: {statistic2.Average:n2}");
Console.WriteLine($"Max: {statistic2.Max}");
Console.WriteLine($"Min: {statistic2.Min}");

Console.WriteLine("WHILE-----------------------------------");

var statistic3 = emploee.GetStatisticWithDoWhile();

Console.WriteLine($"Average: {statistic3.Average:n2}");
Console.WriteLine($"Max: {statistic3.Max}");
Console.WriteLine($"Min: {statistic3.Min}");