int deg = int.Parse(Console.ReadLine());
string time = Console.ReadLine();

string Outfit = string.Empty, Shoes = string.Empty;

if(10 <= deg && deg <= 18)
{
    if (time == "Morning")
    {
        Outfit = "Sweatshirt";
        Shoes = "Sneakers";
    }
    else if (time == "Afternoon")
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";

    }
    else if (time == "Evening")
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";

    }
}
else if(18 < deg && deg <= 24)
{
    if (time == "Morning")
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";

    }
    else if (time == "Afternoon")
    {
        Outfit = "T-Shirt";
        Shoes = "Sandals";

    }
    else if (time == "Evening")
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";

    }
}
else if(deg >= 25)
{
    if (time == "Morning")
    {
        Outfit = "T-Shirt";
        Shoes = "Sandals";

    }
    else if (time == "Afternoon")
    {
        Outfit = "Swim Suit";
        Shoes = "Barefoot";

    }
    else if (time == "Evening")
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";

    }
}

Console.WriteLine($"It's {deg} degrees, get your {Outfit} and {Shoes}.");