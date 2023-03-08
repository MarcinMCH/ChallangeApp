var name = "Ewa";
var sex = "k";
var age = 18;

if (sex == "m")
{
    if (age < 18)
    {
        if (name == "Marcin")
        {
            Console.WriteLine("Niepełnoletni mężczyzna o imieniu Marcin");
        }
        else
        {
            Console.WriteLine("Niepełnoletni mężczyzna");
        }

    }
    else
    {
        if (name == "Marcin")
        {
            Console.WriteLine("Pełnoletni mężczyzna o imieniu Marcin");
        }
        else
        {
            Console.WriteLine("Pełnoletni mężczyzna");
        }
    }
}
else
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30lat");
    }
    else if (age > 30 && age == 33)
    {
        if (name == "Ewa")
        {
            Console.WriteLine("Ewa, lat 33");
        }
        else
        {
            Console.WriteLine("Kobieta w wieku 33 lat");
        }
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}