using System.Runtime.CompilerServices;

namespace ChallangeApp
{
    public class User
    {
        private List<int> score = new List<int>();
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public string login { get; private set; }
        public string password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
