int n = int.Parse(Console.ReadLine());

int max = int.MinValue;

int sum = 0;

for (int i = 0; i < n; i++)
{
    int curr = int.Parse(Console.ReadLine());
    max = Math.Max(curr, max);
    sum += curr;
}

if(max == sum - max)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = {0}", max);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = {0}", Math.Abs(max - (sum - max)));
}