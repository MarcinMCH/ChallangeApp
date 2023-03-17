namespace ChallangeApp;
public class Emploee
{
    // Konstruktor
    public Emploee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    // Pola
    public string name { get; private set; }
    public string surname { get; private set; }
    public int age { get; private set; }


    // Pola do metody maxScoreMetod
    private List<int> score = new List<int>();
    private int point;
    public int max;


    //Metody
    public void AddScore(int score)
    {
        this.score.Add(score);
    }

    public void maxScoreMetod()
    {
        this.point = 0;
        foreach (int score in score)
        {
            if (score > this.point)
            {
                this.point = score;
            }
            this.max = this.point;
        }
    }
}
