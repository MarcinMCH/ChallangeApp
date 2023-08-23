namespace ChallangeApp
{
    public abstract class EmploeeBase : IEmploy
    {
        public EmploeeBase (string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrades(float grade);

        public abstract void AddGrades(string grade);

        public abstract void AddGrades(double grade);

        public abstract void AddGrades(long grade);

        public abstract void AddGrades(char grade);

        public abstract Statistics GetStatistic();
    }
}
