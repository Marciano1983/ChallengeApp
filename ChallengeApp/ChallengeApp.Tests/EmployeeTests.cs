using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TheHighestGrade_ShouldBeMaxGrade()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(3);
            employee.AddGrade(4.3f);
            employee.AddGrade(5.5f);
            
            var max = employee.GetStatistics().Max;

            Assert.AreEqual(5.5, max);
        }

        [Test]
        public void TheLowestGrade_ShouldBeMinGrade()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(1.5f);
            employee.AddGrade(4.5f);
            employee.AddGrade(6);

            var min = employee.GetStatistics().Min;

            Assert.AreEqual(1.5, min);
        }

        [Test]
        public void ThreeAddedGradesDivideByThree_ShouldBeAverageGrade()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(0);
            employee.AddGrade(3.5f);
            employee.AddGrade(5.5f);

            var average = employee.GetStatistics().Average;

            Assert.AreEqual(3, average);
        }
    }
}