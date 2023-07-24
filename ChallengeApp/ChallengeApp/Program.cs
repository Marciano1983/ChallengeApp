using ChallengeApp;

Console.WriteLine("Witamy w Programie BEST SUPERVISOR do oceny Kadry Kierowniczej");
Console.WriteLine("==============================================================");
Console.Write("Podaj swoje imię: ");
var name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Witaj {name}! Już za chwilę będziesz mógł ocenić Kierownika.");
Console.WriteLine();

var supervisor = new Supervisor("Jan", "Kowalski");

while (true)
{
    Console.WriteLine("Podaj ocenę Kierownika (aby wyjść - wybierz 'q'): ");
    var input = Console.ReadLine();

    if (input == "q")
    {
        Console.WriteLine();
        Console.WriteLine("Dodawanie ocen zakończone!");
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics = supervisor.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie dot. ocen Kierownika.");
Console.WriteLine("==================================");
Console.WriteLine($"Minimalna ocena kierownika:  {statistics.Min}");
Console.WriteLine($"Maksymalna ocena kierownika: {statistics.Max}");
Console.WriteLine($"Średnia ocena kierownika:    {statistics.Average:N2}");
Console.WriteLine("==================================");
Console.WriteLine();
Console.WriteLine("Dziękujemy za wystawione oceny.");
Console.WriteLine("Dzięki Tobie stajemy się lepsi!");



//Console.WriteLine("Witamy w Programie BEST EMPLOYEE do oceny Pracowników");
//Console.WriteLine("=====================================================");
//Console.Write("Podaj swoje imię: ");
//var name = Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine($"Witaj {name}! Już za chwilę będziesz mógł ocenić Pracownika.");
//Console.WriteLine();

//var employee = new Employee("Adam", "Nowak");

//while (true)
//{
//    Console.WriteLine("Podaj ocenę Pracownika (aby wyjść - wybierz 'q'): ");
//    var input = Console.ReadLine();

//    if (input == "q")
//    {
//        Console.WriteLine();
//        Console.WriteLine("Dodawanie ocen zakończone!");
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception catched: {ex.Message}");
//    }
//}

//var statistics = employee.GetStatistics();

//Console.WriteLine();
//Console.WriteLine("Podsumowanie dot. ocen Pracownika.");
//Console.WriteLine("==================================");
//Console.WriteLine($"Minimalna ocena pracownika:  {statistics.Min}");
//Console.WriteLine($"Maksymalna ocena pracownika: {statistics.Max}");
//Console.WriteLine($"Średnia ocena pracownika:    {statistics.Average:N2}");
//Console.WriteLine("==================================");
//Console.WriteLine();
//Console.WriteLine("Dziękujemy za wystawione oceny.");
//Console.WriteLine("Dzięki Tobie stajemy się lepsi!");
