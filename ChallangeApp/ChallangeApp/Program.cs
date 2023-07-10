using ChallangeApp;

var emploee = new Emploee("Marcin", "Chmara");
emploee.AddGrades("Marcin");
emploee.AddGrades("1000");
emploee.AddGrades("2,5");
emploee.AddGrades(8065465484622365);
emploee.AddGrades("2,5");
emploee.AddGrades("0");

var statistic = emploee.GetStatistic();

Console.WriteLine($"Average: {statistic.Average:n2}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");