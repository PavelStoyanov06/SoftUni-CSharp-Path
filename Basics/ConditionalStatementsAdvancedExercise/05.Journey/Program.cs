double budget = double.Parse(Console.ReadLine());
string season =  Console.ReadLine();

string loc = string.Empty;
string type = string.Empty;
double price = default;

if(budget <= 100)
{
    loc = "Bulgaria";
    if (season == "summer")
    {
        type = "Camp";
        price = budget * 30 / 100.0;
    }
    else if(season == "winter")
    {
        type = "Hotel";
        price = budget * 70 / 100.0;
    }
}
else if(budget > 100 && budget <= 1000)
{
    loc = "Balkans";
    if (season == "summer")
    {
        type = "Camp";
        price = budget * 40 / 100.0;
    }
    else if (season == "winter")
    {
        type = "Hotel";
        price = budget * 80 / 100.0;
    }
}
else if(budget > 1000)
{
    loc = "Europe";
    type = "Hotel";
    price = budget * 90 / 100.0;
}

Console.WriteLine($"Somewhere in {loc}");
Console.WriteLine($"{type} - {price:f2}");