// Zadanie dzień 4

string name = "Ewa";
bool female = false;
int age = 33;

if (female == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (name != "Ewa" && age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (name == "Ewa")
    {
        Console.WriteLine("Czy to ty byłeś Ewą?");
    }
}
