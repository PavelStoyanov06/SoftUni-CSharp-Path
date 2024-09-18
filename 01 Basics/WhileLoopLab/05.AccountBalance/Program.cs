string input = Console.ReadLine();

double sum = 0;

while(input != "NoMoreMoney")
{
    double money = double.Parse(input);
    if (money < 0)
    {
        Console.WriteLine("Invalid operation!");
        input = Console.ReadLine();
        break;
    }
    Console.WriteLine($"Increase: {money:f2}");
    sum+= money;
    input = Console.ReadLine();
}

Console.WriteLine($"Total: {sum:f2}");