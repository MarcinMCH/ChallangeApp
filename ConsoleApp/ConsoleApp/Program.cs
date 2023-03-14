using ChallangeApp;

User user1 = new User("Marcin", "Pop2344qa");
User user2 = new User("Asia", "KokoSpoko0");
User user3 = new User("Kacper", "13254");
User user4 = new User("Marta", "KLopsik");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);