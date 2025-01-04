using System;
using ChallangeApp;

EployDelate Person1 = new EployDelate("Jan", "Kowalski" ,15);
Person1.AddScore(7);
Person1.AddScore(9);
Person1.AddScore(2);
Person1.AddScore(5);
Person1.AddScore(6);

EployDelate Person2 = new EployDelate("Mirek", "Bodnar", 18);
Person2.AddScore(7);
Person2.AddScore(5);
Person2.AddScore(1);
Person2.AddScore(9);
Person2.AddScore(9);

EployDelate Person3 = new EployDelate("Katarzyna", "Flik", 8);
Person3.AddScore(1);
Person3.AddScore(9);
Person3.AddScore(3);
Person3.AddScore(4);
Person3.AddScore(8);

Console.WriteLine("Witaj w programie XD");
Console.WriteLine("==========================================");
Console.WriteLine("Poniżej dane zwycięscy");


Console.WriteLine(Person3.Name + " " + Person3.Surname);