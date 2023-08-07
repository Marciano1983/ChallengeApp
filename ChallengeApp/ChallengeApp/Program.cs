using ChallengeApp;

Console.WriteLine("Witamy w Programie BEST EMPLOYEE do oceny Pracowników");
Console.WriteLine("=======================================================");
Console.Write("Podaj swoje imię: ");
var name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Witaj {name}! Już za chwilę będziesz mógł ocenić Pracownika.");
Console.WriteLine();

var employee = new EmployeeInFile("Jan", "Kowalski");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę!");
    Console.WriteLine();
}

while (true)
{
    Console.WriteLine("Podaj ocenę Pracownika (aby wyjść - wybierz 'q'): ");
    var input = Console.ReadLine();

    if (input == "q")
    {
        Console.WriteLine();
        Console.WriteLine("Dodawanie ocen zakończone!");
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var result = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie dot. ocen Pracownika.");
Console.WriteLine("==================================");
Console.WriteLine($"Minimalna ocena Pracownika:  {result.Min}");
Console.WriteLine($"Maksymalna ocena Pracownika: {result.Max}");
Console.WriteLine($"Średnia ocena Pracownika:    {result.Average:N2}");
Console.WriteLine("==================================");
Console.WriteLine();
Console.WriteLine("Dziękujemy za wystawione oceny.");
Console.WriteLine("Dzięki Tobie stajemy się lepsi!");




















