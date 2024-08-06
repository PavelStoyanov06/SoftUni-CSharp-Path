int n = 2 * int.Parse(Console.ReadLine());

int sumLeft = 0, sumRight = 0;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if(i <= n / 2)
    {
        sumLeft += num;
    }
    else
    {
        sumRight += num;
    }
}

if(sumLeft == sumRight)
{
    Console.WriteLine($"Yes, sum = {sumLeft}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
}