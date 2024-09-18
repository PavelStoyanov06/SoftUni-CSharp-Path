int n = int.Parse(Console.ReadLine());

int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i < n; i++)
{
    int curr = int.Parse(Console.ReadLine());
    min = Math.Min(min, curr);
    max = Math.Max(max, curr);
}

Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");