namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectedScore_ShouldReturnCorrectedResoult()
        {
            // arrange
            var user = new User("Marcin", "5698");
            user.AddScore(5);
            user.AddScore(2);

            // act
            var result = user.result;

            // assert
            Assert.AreEqual(7, result);
        }
    }
}
