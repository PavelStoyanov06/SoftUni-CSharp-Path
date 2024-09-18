double budget = double.Parse(Console.ReadLine());
int numExtras = int.Parse(Console.ReadLine());
double uniformPrice = double.Parse(Console.ReadLine());

double backdrop = budget * (10 / 100.0);

double totalUniformPrice = uniformPrice * numExtras;

if(numExtras > 150)
{
    totalUniformPrice -= (10/100.0) *totalUniformPrice;
}

double total = totalUniformPrice + backdrop;

if (total > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {total - budget:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - total:f2} leva left.");
}
