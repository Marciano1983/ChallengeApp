using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade("2000");
employee.AddGrade("Adam");
employee.AddGrade(1.2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"The highest grade: {statistics.Max}");
Console.WriteLine($"The lowest grade:  {statistics.Min}");
Console.WriteLine($"The average grade: {statistics.Average:N2}");