int budget = int.Parse(Console.ReadLine());
string season =  Console.ReadLine();
int count = int.Parse(Console.ReadLine());

double price = 0;

if(season == "Spring")
{
    price = 3000;
}
else if(season == "Autumn" || season == "Summer")
{
    price = 4200;
}
else if(season == "Winter")
{
    price = 2600;
}

if(count <= 6)
{
    price -= price * 10 / 100.0;
}
else if(count > 6 &&  count <= 11)
{
    price -= price * 15 / 100.0;
}
else if(count > 11)
{
    price -= price * 25 / 100.0;
}

if( count % 2 == 0 && season != "Autumn")
{
    price -= price * 5 / 100.0;

}

if (budget >= price)
{
    Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
}