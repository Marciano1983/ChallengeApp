/// Napisz w Program.cs kod, w którym:
/// - zadeklarujesz zmienną z imieniem
/// - zadeklarujesz zmienną z płcią (dobierz zmienną)
/// - zadeklarujesz zmienną z wiekiem
/// - zweryfikujesz dane i wyświetlisz
/// jeden z komunikatów:
/// (1): "Kobieta poniżej 30 lat"
/// (2): "Ewa, lat 33"
/// (3): "Niepełnoletni Mężczyzna"
/// --------------------
/// (możesz dodać swoje)

var name = "Ewa";
var isWoman = true; 
var age = 25;

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (isWoman != true && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna.");
}
else if (isWoman != true && age >= 18)
{
    Console.WriteLine("Pełnoletni Mężczyzna.");
}