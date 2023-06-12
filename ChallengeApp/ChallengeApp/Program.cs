// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek 
// oraz punkty pracownika w postaci liczb całkowitych.
//
// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu
// od 1 do 10.
//
// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen
// a następnie wyświetli jego dane oraz wynik.

using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 36);
Employee employee2 = new Employee("Roman", "Nowak", 28);
Employee employee3 = new Employee("Ania", "Lewandowska", 45);

employee1.AddScore(1);
employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(6);

employee2.AddScore(7);
employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(5);

employee3.AddScore(6);
employee3.AddScore(3);
employee3.AddScore(8);
employee3.AddScore(1);
employee3.AddScore(5);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

var best = new List<int>() { result1, result2, result3 };
var bestScore = best.Max();

if (result1 == bestScore)
{
    Console.WriteLine("Najlepszą ocenę osiągnął pracownik {0} {1}, {2} lat z wynikiem {3}", employee1.Name, employee1.Surname, employee1.Age, bestScore);
}
if (result2 == bestScore)
{
    Console.WriteLine("Najlepszą ocenę osiągnął pracownik {0} {1}, {2} lat z wynikiem {3}.", employee2.Name, employee2.Surname, employee2.Age, bestScore);
}
if (result3 == bestScore)
{
    Console.WriteLine("Najlepszą ocenę osiągnął pracownik {0} {1}, {2} lat z wynikiem {3}.", employee3.Name, employee3.Surname, employee3.Age, bestScore);
}





