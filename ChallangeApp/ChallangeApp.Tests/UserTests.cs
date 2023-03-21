namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserScoreSumIsPositive_ResultShouldBePositive()
        {
            // arrange
            var user = new User("Marcin", "5698");
            user.AddScore(5);
            user.AddScore(2);
            user.AddScore(5);
            user.AddScore(3);

            // act
            var result = user.result;

            // assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void WhenUserScoreSumIsNegative_ResultShouldBeNegative()
        {
            // arrange
            var user = new User("Marcin", "5698");
            user.AddScore(5);
            user.AddScore(2);
            user.AddScore(-3);
            user.AddScore(-8);

            // act
            var result = user.result;

            // assert
            Assert.AreEqual(-4, result);
        }

        [Test]
        public void WhenUserScoreSumIsZero_ResultShouldBeZero()
        {
            // arrange
            var user = new User("Marcin", "5698");
            user.AddScore(7);
            user.AddScore(4);
            user.AddScore(-3);
            user.AddScore(-8);

            // act
            var result = user.result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}
