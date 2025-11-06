string ocena = Console.ReadLine();
int warunek = int.Parse(ocena);

if (warunek < 1 || warunek > 6)
{
    Console.WriteLine("Nieprawidłowa ocena");
}
else if (warunek == 1 || warunek == 2)
{
    Console.WriteLine("Niedostateczny");
}
else if (warunek == 3)
{
    Console.WriteLine("Dostateczny");
}
else if (warunek == 4)
{
    Console.WriteLine("Dobry");
}
else if (warunek == 5)
{
    Console.WriteLine("Bardzo dobry");
}
else if (warunek == 6)
{
    Console.WriteLine("Celujący");
}


