string type = Console.ReadLine();

double price = default(double);

double discount = default(double);

int count = int.Parse(Console.ReadLine());

if (type == "Roses")
{
    price = 5;
    if(count > 80)
    {
        discount = -10 / 100.0;
    }
}
else if (type == "Dahlias")
{
    price = 3.8;
    if(count > 90)
    {
        discount = -15 / 100.0;
    }
}
else if (type == "Tulips")
{
    price = 2.8;
    if(count > 80)
    {
        discount = - 15/ 100.0;
    }
}
else if(type == "Narcissus")
{
    price = 3;

    if(count < 120)
    {
        discount = 15 / 100.0;
    }
}
else if (type == "Gladiolus")
{
    price = 2.5;
    if(count < 80)
    {
        discount = 20 / 100.0;
    }
}

double total = price * count;
total += total * discount;

double budget = double.Parse(Console.ReadLine());

if(total > budget)
{
    Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
}
else
{
    Console.WriteLine($"Hey, you have a great garden with {count} {type} and {budget-total:f2} leva left.");
}