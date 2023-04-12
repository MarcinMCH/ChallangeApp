using System;

namespace ChallangeApp;
public class Emploee
{
    private List<float> grades = new List<float>();
    public Emploee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
    public string Name { get; private set; }

    public string Surname { get; private set; }

    public void addGrades(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade value");
        }
    }
    public void addGrades(string grade)
    {
        if (float.TryParse(grade.Replace('.',','), out float result) && result >= 0 && result <= 100)
        {
            this.addGrades(result);
        }
        else if (result < 0 || result > 100)
        {
            Console.WriteLine("String is float but value is invalid");
        }
        else
        {
            Console.WriteLine("String is not float");
        }
    }
    public void addGrades(double grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            float gradeToFloat = (float)grade;
            this.grades.Add(gradeToFloat);
        }
        else
        {
            Console.WriteLine("Invalid grade value");
        }
    }

    public void addGrades(long grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            float gradeToFloat = (float)grade;
            this.grades.Add(gradeToFloat);
        }
        else
        {
            Console.WriteLine("Invalid grade value (long)");
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

        return statistic;
    }
}
