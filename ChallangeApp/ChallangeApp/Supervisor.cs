namespace ChallangeApp
{
    public class Supervisor : IEmploy
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
                //Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrades(string grade)
        { 
            switch (grade)
            {
                case "6":
                    this.AddGrades(100);
                    break;
                case "6-":
                case "-6":
                    this.AddGrades(95);
                    break;
                case "5+":
                case "+5":
                    this.AddGrades(85);
                    break;
                case "5":
                    this.AddGrades(80);
                    break;
                case "5-":
                case "-5":
                    this.AddGrades(75);
                    break;
                case "4+":
                case "+4":
                    this.AddGrades(65);
                    break;
                case "4":
                    this.AddGrades(60);
                    break;
                case "4-":
                case "-4":
                    this.AddGrades(55);
                    break;
                case "3+":
                case "+3":
                    this.AddGrades(45);
                    break;
                case "3":
                    this.AddGrades(40);
                    break;
                case "3-":
                case "-3":
                    this.AddGrades(35);
                    break;
                case "2+":
                case "+2":
                    this.AddGrades(25);
                    break;
                case "2":
                    this.AddGrades(20);
                    break;
                case "2-":
                case "-2":
                    this.AddGrades(15);
                    break;
                case "1+":
                case "+1":
                    this.AddGrades(5);
                    break;
                case "1":
                    this.AddGrades(0);
                    break;
                default:
                    if (float.TryParse(grade.Replace('.', ','), out float result))
                    {
                        this.AddGrades(result);
                    }
                    else
                    {
                        throw new Exception("String value is not float");
                    }
                    break;
            }
        }
        public void AddGrades(double grade)
        {
            float gradeToFloat = (float)grade;
            this.AddGrades(gradeToFloat);
        }

        public void AddGrades(long grade)
        {
            float gradeToFloat = (float)grade;
            this.AddGrades(gradeToFloat);
        }

        public void AddGrades(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                case 'F':
                case 'f':
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Wrong Letter");
                    //Console.WriteLine("Wrong Letter");
            }
        }
        public Statistics GetStatistic()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;

            switch (statistic.Average)
            {
                case var avarge when avarge >= 80:
                    statistic.AvarageLetter = 'A';
                    break;
                case var avarge when avarge >= 60:
                    statistic.AvarageLetter = 'B';
                    break;
                case var avarge when avarge >= 40:
                    statistic.AvarageLetter = 'C';
                    break;
                case var avarge when avarge >= 20:
                    statistic.AvarageLetter = 'D';
                    break;
                default:
                    statistic.AvarageLetter = 'E';
                    break;
            }

            return statistic;
        }
    }
}
