
namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntShouldReturnTheSameObject()
        {
            // arrange
            int number1 = 27;
            int number2 = 27;

            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void FloatShouldReturnTheSameObject()
        {
            // arrange
            float number1 = 3.14f;
            float number2 = 3.14f;

            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void StringShouldReturnTheSameObject()
        {
            // arrange
            string word1 = "kotlet";
            string word2 = "kotlet";

            // act


            // assert
            Assert.AreEqual(word1, word2);
        }

        [Test]
        public void GetUserShouldReturnDiffrentObject()
        {
            // arrange
            var user1 = GetUser("Marcin");
            var user2 = GetUser("Marcin");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser (string name)
        {
            return new User(name);
        }
    }
}
