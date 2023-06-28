using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade("20");   // string
employee.AddGrade("Adam"); // string - błąd (nie da się sparsować na float)
employee.AddGrade(1.2);    // double
employee.AddGrade(6);      // int
employee.AddGrade(4.5f);   // float
employee.AddGrade(9223372036854775807);  // long - błąd (przekroczony zakres grade)
employee.AddGrade(7.2m);   // decimal 

var statistics =  employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

//Console.WriteLine($"The highest grade: {statistics.Max}");
//Console.WriteLine($"The lowest grade:  {statistics.Min}");
//Console.WriteLine($"The average grade: {statistics.Average:N2}");

