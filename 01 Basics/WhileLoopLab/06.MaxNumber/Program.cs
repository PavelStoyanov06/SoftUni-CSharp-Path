string input = Console.ReadLine();

int max = int.MinValue;

while (input != "Stop")
{
    max = Math.Max(max, int.Parse(input));
    input = Console.ReadLine();
}

Console.WriteLine(max);