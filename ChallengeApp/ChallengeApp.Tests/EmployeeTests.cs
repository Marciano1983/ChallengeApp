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

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5.5, statistics.Max);
        }

        [Test]
        public void TheLowestGrade_ShouldBeMinGrade()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(1.5f);
            employee.AddGrade(4.5f);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(1.5, statistics.Min);
        }

        [Test]
        public void ThreeAddedGradesDivideByThree_ShouldBeAverageGrade()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(1);
            employee.AddGrade(3.5f);
            employee.AddGrade(5.5f);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void ThreeLetterGrades_ShouldReturnCorrectMinGradeInTheFormOfANumber()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(60, statistics.Min);
        }

        [Test]
        public void ThreeLetterGrades_ShouldReturnCorrectMaxGradeInTheFormOfANumber()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }
        [Test]
        public void ThreeLetterGrades_ShouldReturnCorrectAveregeGradeInTheFormOfANumber()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(80, statistics.Average);
        }

        [Test]
        public void ThreeLetterGrades_ShouldReturnCorrectAveregeGradeInTheFormOfALetter()
        {
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreEqual('A', statistics.AverageLetter);
        }

    }
}