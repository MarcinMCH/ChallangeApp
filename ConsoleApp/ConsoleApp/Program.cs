using ChallangeApp;

Emploee emploee1 = new Emploee("Karol", "Kowalski", 26);
Emploee emploee2 = new Emploee("Monika", "Nowak", 18);
Emploee emploee3 = new Emploee("Hans", "Klos", 80);

emploee1.AddScore(6);
emploee1.AddScore(1);
emploee1.AddScore(3);
emploee1.AddScore(9);
emploee1.AddScore(3);

emploee2.AddScore(4);
emploee2.AddScore(8);
emploee2.AddScore(8);
emploee2.AddScore(7);
emploee2.AddScore(9);

emploee3.AddScore(1);
emploee3.AddScore(1);
emploee3.AddScore(5);
emploee3.AddScore(2);
emploee3.AddScore(1);

//aktualnie nie wiem jak zrobić metodę która zwraca wartość

emploee1.maxScoreMetod();
emploee2.maxScoreMetod();
emploee3.maxScoreMetod();

List<(int, Emploee)> check = new List<(int, Emploee)>
{
    (emploee1.max, emploee1),
    (emploee2.max, emploee2),
    (emploee3.max, emploee3)
};

var maxValue = 0;
var emploeeWithHightScore = emploee1;
foreach (var (a, b) in check)
{
    if (a > maxValue)
    {
        maxValue = a;
        emploeeWithHightScore = b;
    }
}

Console.WriteLine("Procownik z najwyższą oceną (" + maxValue + ") to:");
Console.WriteLine("Imię: " + emploeeWithHightScore.name);
Console.WriteLine("Nazwisko: " + emploeeWithHightScore.surname);
Console.WriteLine("Wiek: " + emploeeWithHightScore.age);