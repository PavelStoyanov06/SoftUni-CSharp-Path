int days = int.Parse(Console.ReadLine());
string type =  Console.ReadLine();
string rating = Console.ReadLine();

double price = default;

double dis = default;

if(type == "room for one person")
{
    price = 18;
}
else if(type == "apartment")
{
    price = 25;
    if(days < 10)
    {
        dis = 30 / 100.0;
    }
    else if(days >= 10 && days < 15)
    {
        dis = 35 / 100.0;
    }
    else if(days >= 15)
    {
        dis = 50 / 100.0;
    }
}
else if( type == "president apartment")
{
    price = 35;
    if (days < 10)
    {
        dis = 10 / 100.0;
    }
    else if (days >= 10 && days < 15)
    {
        dis = 15 / 100.0;
    }
    else if (days >= 15)
    {
        dis = 20 / 100.0;
    }
}

double total = price * (days - 1);

total -= total * dis;

if(rating == "positive")
{
    total += 25 / 100.0 * total;
}
else if(rating == "negative")
{
    total -= 10 / 100.0 * total;
}

Console.WriteLine($"{total:f2}");