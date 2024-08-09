string input = Console.ReadLine();

while(input != "End")
{
    double needed = double.Parse(Console.ReadLine());
    double sum = 0;
    while(sum < needed)
    {
        sum += double.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Going to {input}!");
    input = Console.ReadLine();
}
