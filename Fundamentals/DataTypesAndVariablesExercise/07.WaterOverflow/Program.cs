int n = int.Parse(Console.ReadLine());

int level = 0;

for (int i = 0; i < n; i++)
{
    int quantity = int.Parse(Console.ReadLine());
    if(level + quantity > 255)
    {
        Console.WriteLine("Insufficient capacity!");
        continue;
    }
    level += quantity;
}

Console.WriteLine(level);