using ChallangeApp;

var emploee = new Emploee("Marcin", "Chmara");
emploee.addGrades("Marcin");
emploee.addGrades("1000");
emploee.addGrades("2,5");
emploee.addGrades(3.500000000000000000000000621358846854655555555555555555555555555555555555555555555555555555555555555555555555555555555555555555);
emploee.addGrades(7);
emploee.addGrades(8065465484622365482);
emploee.addGrades("1,5");
emploee.addGrades("9.23");

var statistic = emploee.GetStatistic();

Console.WriteLine($"Average: {statistic.Average:n2}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");
