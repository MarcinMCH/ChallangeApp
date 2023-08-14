namespace ChallangeApp
{
    public interface IEmploy
    {
        string Name { get; }
        string Surname { get; }

        public void AddGrades(float grade);

        public void AddGrades(string grade);

        public void AddGrades(double grade);

        public void AddGrades(long grade);

        public void AddGrades(char grade);

        public Statistics GetStatistic();
    }
}
