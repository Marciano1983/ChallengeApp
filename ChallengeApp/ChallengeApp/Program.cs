using ChallengeApp;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w Programie BEST EMPLOYEE do oceny Pracowników");
Console.WriteLine("=====================================================");
Console.Write("Podaj swoje imię: ");
var name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Witaj {name}! Już za chwilę będziesz mógł ocenić Pracownika.");
Console.WriteLine();

var employee = new Employee("Adam", "Nowak");

while (true)
{
    Console.WriteLine("Podaj ocenę Pracownika (aby wyjść - wybierz 'q'): ");
    var input = Console.ReadLine();

    if(input == "q")
    {
        Console.WriteLine();
        Console.WriteLine("Dodawanie ocen zakończone!");
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("Podsumowanie dot. ocen Pracownika.");
Console.WriteLine("==================================");
Console.WriteLine($"Minimalna ocena pracownika:  {statistics.Min}");
Console.WriteLine($"Maksymalna ocena pracownika: {statistics.Max}");
Console.WriteLine($"Średnia ocena pracownika:    {statistics.Average:N2}");
Console.WriteLine("==================================");
Console.WriteLine();
Console.WriteLine("Dziękujemy za wystawione oceny.");
Console.WriteLine("Dzięki Tobie stajemy się lepsi!");

