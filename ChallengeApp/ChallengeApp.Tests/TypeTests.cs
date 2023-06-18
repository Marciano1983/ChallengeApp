namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenCompareTwoDiffrentStringVariablesTheirValuesAreEqual() 
        {
            //arrange
            string name1 = "Adam";
            string name2 = "Adam";

            // act

            // assert 
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void WhenCompareTwoDiffrentIntVariablesTheirValuesAreEqual()  
        {
            //arrange
            int number1 = 2;
            int number2 = 2;

            // act

            // assert 
           Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenCompareTwoDiffrentFloatVariablesTheirValuesAreEqual()
        {
            //arrange
            float number1 = 1.4f;
            float number2 = 1.4f;

            // act

            // assert 
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDiffrentObjects() 
        {
            //arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }
        
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
