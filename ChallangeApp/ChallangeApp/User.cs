namespace ChallangeApp
{
    public class User
    {
        public User (string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string login { get; private set; }
        public string password { get; private set; }

        public int result
        {
            get
            {
                return this.score.Sum();
            }
        }

        private List<int> score = new List<int>();
        public void AddScore (int number)
        {
            this.score.Add (number);
        }
    }
}
