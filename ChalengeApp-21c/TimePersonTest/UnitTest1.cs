using ChalengeApp_21c;

namespace TimePersonTest
{
    public class Tests
    {
        [Test]  //1//

        public void MaxTimeTest()
        {

            // arrange
            var employee = new TimePersonInMemory("Wxxx", "Wxxx");

            employee.AddGrade(540);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(540, statistics.Max);

        }


        [Test]  //2
        public void MinTimesTest()
        {
            // arrange
            var employee = new TimePersonInMemory("Wxxx", "Wxxx");

            employee.AddGrade(30);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(30, statistics.Min);

        }

        [Test]  // 3
        public void AverageTimeTest()
        {
            // arrange
            var employee = new TimePersonInMemory("Wxxx", "Wxxx");
            employee.AddGrade(165);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(165, statistics.Average);
        }
    }
}