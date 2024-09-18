double amount = double.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());
double saber =  double.Parse(Console.ReadLine());
double robe =  double.Parse(Console.ReadLine());
double belt = double.Parse(Console.ReadLine());

double saberTotal = saber * Math.Ceiling(110 / 100.0 * count);

double robeTotal = robe * count;

double beltTotal = belt * (count - count / 6);

double total = saberTotal + robeTotal + beltTotal;

if(amount >= total)
{
    Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {total - amount:f2}lv more.");
}