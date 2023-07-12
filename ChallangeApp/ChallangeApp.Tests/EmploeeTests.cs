namespace ChallangeApp.Tests
{
    public class EmploeeTests
    {
        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var emploee = new Emploee("Marcin", "Chmara");
            emploee.AddGrades(0);
            emploee.AddGrades(6);
            emploee.AddGrades(50);
            // act
            var statistic = emploee.GetStatistic();
            // assert
            Assert.AreEqual(50, statistic.Max);
        }

        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var emploee = new Emploee("Marcin", "Chmara");
            emploee.AddGrades(75);
            emploee.AddGrades(6);
            emploee.AddGrades(5);
            // act
            var statistic = emploee.GetStatistic();
            // assert
            Assert.AreEqual(5, statistic.Min);
        }

        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var emploee = new Emploee("Marcin", "Chmara");
            emploee.AddGrades(2);
            emploee.AddGrades(5);
            emploee.AddGrades(3);
            // act
            var statistic = emploee.GetStatistic();
            // assert
            Assert.AreEqual(Math.Round(3.33333, 2), Math.Round(statistic.Average, 2));
        }
    }
}
