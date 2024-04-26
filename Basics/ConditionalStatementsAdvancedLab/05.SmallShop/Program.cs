string product = Console.ReadLine();
string town = Console.ReadLine();
double amount = double.Parse(Console.ReadLine());

double price = 0;

if (product == "coffee")
{
    if(town == "Sofia")
    {
        price = 0.5;
    }
    else if(town == "Plovdiv")
    {
        price = 0.4;
    }
    else if(town == "Varna")
    {
        price = 0.45;
    }
}
else if (product == "water")
{
    if (town == "Sofia")
    {
        price = 0.8;
    }
    else if (town == "Plovdiv")
    {
        price = 0.7;
    }
    else if (town == "Varna")
    {
        price = 0.7;
    }
}
else if (product == "beer")
{
    if (town == "Sofia")
    {
        price = 1.2;
    }
    else if (town == "Plovdiv")
    {
        price = 1.15;
    }
    else if (town == "Varna")
    {
        price = 1.1;
    }
}
else if (product == "sweets")
{
    if (town == "Sofia")
    {
        price = 1.45;
    }
    else if (town == "Plovdiv")
    {
        price = 1.3;
    }
    else if (town == "Varna")
    {
        price = 1.35;
    }
}
else if (product == "peanuts")
{
    if (town == "Sofia")
    {
        price = 1.6;
    }
    else if (town == "Plovdiv")
    {
        price = 1.5;
    }
    else if (town == "Varna")
    {
        price = 1.55;
    }
}

double total = price * amount;

Console.WriteLine(total);