using ChallangeApp;

Console.WriteLine("Witaj w programie XYZ do oceny Pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("Podaj pierwszą ocenę Pracownika:");

var emploee = new EmploeeInFile("Marcin", "Chmara");
emploee.AddGrades(1.5f);

//do
//{
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        emploee.AddGrades(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//    Console.WriteLine("Podaj kolejną ocenę Pracownika");

//} while (true);

//var statistic = emploee.GetStatistic();
//Console.WriteLine();
//Console.WriteLine("==========================================");
//Console.WriteLine($"Średnia: {statistic.Average}");
//Console.WriteLine($"Max: {statistic.Max}");
//Console.WriteLine($"Min: {statistic.Min}");
//Console.WriteLine($"Ocena /{statistic.AvarageLetter}/ dla średniej {statistic.Average}");