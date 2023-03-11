/*int[] grades = new int[5];

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");


for (int i=0; i<dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}

Console.WriteLine("zmodyfikowana pętla FOR");

foreach (var day in dayOfWeeks)
{
    Console.WriteLine("to jest " + day);
}
*/

//przygotuj program, który policzy ile jakich cyfr występuje w podanej liczbie

int number = 256698777;
string numberToString = number.ToString();
char[] digits = numberToString.ToArray(); // tablica z cyframi z liczby
int[] digitSum = new int[10]; // tablica sumująca cyfry w liczbie
foreach (var digit in digits)
{
    for (int i = 0; i < 10; i++)
    {
        int digitInt = (int)Char.GetNumericValue(digit);
        if (digitInt == i)
        {
            digitSum[i] = digitSum[i] + 1;
        }
    }
}
Console.WriteLine("Podala liczba to: " + number + "\nWyniki:");
int digitInConsole = 0;
foreach (int result in digitSum)
{ 
    Console.WriteLine(digitInConsole+ " >> " + result);
    digitInConsole = digitInConsole + 1;
}