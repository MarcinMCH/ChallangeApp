using ChallangeApp;

var emploee = new Emploee("Marcin", "Chmara");
emploee.AddGrades(5);
emploee.AddGrades(2);
emploee.AddGrades("8.0");

var statistic = emploee.GetStatisticWithFor();

Console.WriteLine($"Average: {statistic.Average:n2}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");