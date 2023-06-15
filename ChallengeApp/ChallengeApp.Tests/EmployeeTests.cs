namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectGoodScores_ShouldReturnCorrectResult()
        {           
            var employee = new Employee("Adam", "Kowalski", 34);
            employee.AddScore(1);
            employee.AddScore(5);
            employee.AddScore(3);
            employee.AddScore(3);

            var result = employee.Result;
            
            Assert.AreEqual(12, result);
        }

        [Test]
        public void WhenEmployeeCollectBadScores_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Adam", "Kowalski", 34);
            employee.AddScore(-1);
            employee.AddScore(-2);
            employee.AddScore(-3);
            employee.AddScore(-3);

            var result = employee.Result;

            Assert.AreEqual(-9, result);
        }

        [Test]
        public void WhenEmployeeCollectGoodAndBadScores_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Adam", "Kowalski", 34);
            employee.AddScore(-1);
            employee.AddScore(2);
            employee.AddScore(-3);
            employee.AddScore(4);

            var result = employee.Result;

            Assert.AreEqual(2, result);
        }

    }
    
}