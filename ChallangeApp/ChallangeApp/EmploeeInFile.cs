namespace ChallangeApp
{
    public class EmploeeInFile : EmploeeBase
    {
        private const string fileName = "grades.txt";

        private List<float> grades = new List<float>();
        public EmploeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrades(string grade)
        {
            if (float.TryParse(grade.Replace('.', ','), out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                throw new Exception("String value is not float");
            }
        }

        public override void AddGrades(double grade)
        {
            float gradeToFloat = (float)grade;
            this.AddGrades(gradeToFloat);
        }

        public override void AddGrades(long grade)
        {
            float gradeToFloat = (float)grade;
            this.AddGrades(gradeToFloat);
        }

        public override void AddGrades(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrades(100f);
                    break;
                case 'B':
                case 'b':
                    this.AddGrades(80f);
                    break;
                case 'C':
                case 'c':
                    this.AddGrades(60f);
                    break;
                case 'D':
                case 'd':
                    this.AddGrades(40f);
                    break;
                case 'E':
                case 'e':
                    this.AddGrades(20f);
                    break;
                case 'F':
                case 'f':
                    this.AddGrades(0f);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public override Statistics GetStatistic()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reder = File.OpenText(fileName))
                {
                    var line = reder.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        this.grades.Add(grade);
                    }
                }
            }

            foreach (var grade in this.grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;

            return statistic;
        }
    }
}
