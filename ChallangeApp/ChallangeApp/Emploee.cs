using System;

namespace ChallangeApp;
public class Emploee : Person
{
    private List<float> grades = new List<float>();
    public Emploee(string name, string surname, char sex)
        : base(name, surname, sex)
    { }
    public Emploee(string name, string surname)
       : base(name, surname)
    { }

    public void AddGrades(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            throw new Exception ("Invalid grade value");
            //Console.WriteLine("Invalid grade value");
        }
    }
    public void AddGrades(string grade)
    {
        if (float.TryParse(grade.Replace('.', ','), out float result))
        {
            this.AddGrades(result);
        }
        else 
        {
            throw new Exception("String value is not float");
            //Console.WriteLine("String is float but value is invalid");
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
        switch(grade) 
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
