string input = Console.ReadLine();

int sumPrime = 0, sumNon = 0;

while (input != "stop")
{
    int num = int.Parse(input);
    if(num < 0)
    {
        Console.WriteLine("Number is negative.");
        input = Console.ReadLine();

        continue;
    }
    if(num == 0)
    {
        sumNon += num;
        input = Console.ReadLine();
        continue;
    }
    bool isPrime = true;
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0)
        {
            sumNon += num;
            isPrime = false;
            break;
        }
    }
    input = Console.ReadLine();
    if (!isPrime)
    {
        continue;
    }
    sumPrime += num;
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNon}");