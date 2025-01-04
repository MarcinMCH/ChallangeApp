using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChallangeApp
{
    public class EployDelate
    {
        private List<int> score = new List<int>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public EployDelate(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }           
    }
}
