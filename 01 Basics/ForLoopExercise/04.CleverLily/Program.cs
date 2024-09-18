int age = int.Parse(Console.ReadLine());
double washPrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int toyCount = 0;

double sum = 0;
int numT = 1;

for (int i = 1; i <= age; i++)
{
    if(i % 2 == 1)
    {
        toyCount++;
        continue;
    }
    sum += 10 * numT - 1;
    numT++;
}

sum += toyCount * toyPrice;

if(sum >= washPrice)
{
    Console.WriteLine($"Yes! {sum - washPrice:f2}");
}
else
{
    Console.WriteLine($"No! {washPrice - sum:f2}");
}