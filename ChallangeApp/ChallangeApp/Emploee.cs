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

    public void AddGrades(float grade)
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
    public void AddGrades(string grade)
    {
        if (float.TryParse(grade.Replace('.', ','), out float result) && result >= 0 && result <= 100)
        {
            this.AddGrades(result);
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

    public Statistics GetStatisticForeach()
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

    public Statistics GetStatisticWithFor()
    {
        var statistic = new Statistics();
        statistic.Average = 0;
        statistic.Max = float.MinValue;
        statistic.Min = float.MaxValue;

        for (var i = 0; i < this.grades.Count; i++)
        {
            statistic.Max = Math.Max(statistic.Max, this.grades[i]);
            statistic.Min = Math.Min(statistic.Min, this.grades[i]);
            statistic.Average += this.grades[i];
        }

        statistic.Average /= this.grades.Count;

        return statistic;
    }

    public Statistics GetStatisticWithDoWhile()
    {
        var statistic = new Statistics();
        statistic.Average = 0;
        statistic.Max = float.MinValue;
        statistic.Min = float.MaxValue;
        var index = 0;

        do
        {
            statistic.Max = Math.Max(statistic.Max, this.grades[index]);
            statistic.Min = Math.Min(statistic.Min, this.grades[index]);
            statistic.Average += this.grades[index];
            index++;
        }
        while (index < this.grades.Count);

        statistic.Average /= index;

        return statistic;
    }

    public Statistics GetStatisticWithWhile()
    {
        var statistic = new Statistics();
        statistic.Average = 0;
        statistic.Max = float.MinValue;
        statistic.Min = float.MaxValue;
        var index = 0;

        while (index < this.grades.Count)
        {
            statistic.Max = Math.Max(statistic.Max, this.grades[index]);
            statistic.Min = Math.Min(statistic.Min, this.grades[index]);
            statistic.Average += this.grades[index];
            index++;
        }

        statistic.Average /= index;

        return statistic;
    }
}
