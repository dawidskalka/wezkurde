string loginPoprawny = "admin";
string hasloPoprawne = "pass123";

string loginUser = "";
string hasloUser = "";
int i = 3;
while (i > 0)
{

    Console.Write("Podaj login: ");
    loginUser = Console.ReadLine();
    Console.Write("Podaj hasło: ");
    hasloUser = Console.ReadLine();

    if (loginUser == loginPoprawny && hasloUser == hasloPoprawne)
    {
        Console.WriteLine("Zalogowano pomyślnie.");
        break;
    }
    else
    {
        Console.WriteLine($"Niepoprawny login lub hasło. Pozostaly {i - 1} proby");
    }

    i--;
    if (i == 0)
    {
        Console.WriteLine("Konto zablokowane.");
        break;
    }
}