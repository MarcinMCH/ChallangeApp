int number1 = 1000000000;
int number2 = 2000000000;
Console.WriteLine(number1 + number2);

// ==
// !=
// >
// <
// >=
// <=

var name = "Marcin";
var age = 60;

if (name == "Marci" || !(age < 40))
{
    Console.WriteLine("JESTEM MARCINEM LUB MAM PONIŻEJ 40 LAT.");
}
else
{
    Console.WriteLine("JESTEM KIMŚ INNYM");
}

// &&
// ||
// !

if (age > 50)
{
    if (name == "Marcin")
    {
        Console.WriteLine("Masz więcej niż 50lat i Masz na imie Marcin");
    }
    else
    {
        Console.WriteLine("Masz więcej niż 50lat");
    }
}
else if (age > 40)
{
    Console.WriteLine("Masz wiek w przedziale 40-50lat");
}
else if (age > 30)
{
    Console.WriteLine("Masz wiek w przedziale 30-40lat");
}
else if (age < 30)
{
    Console.WriteLine("Masz mniej niż 30lat");
}
