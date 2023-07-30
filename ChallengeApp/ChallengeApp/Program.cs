using ChallengeApp;

// Zapisywanie danych do pliku
var employee = new EmployeeInFile("Adam", "Nowak");

employee.AddGrade(1.0f);
employee.AddGrade(2d);
employee.AddGrade(3);
employee.AddGrade('E'); // 20
employee.AddGrade("4");

// Odczytywanie danych z pliku
var result = employee.GetStatistics();

Console.WriteLine($"Minimalna ocena Pracownika:  {result.Min}");
Console.WriteLine($"Maksymalna ocena Pracownika: {result.Max}");
Console.WriteLine($"Średnia ocena Pracownika:    {result.Average:N2}");
