int n = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 0; i < n; i++)
{
    double price = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int count = int.Parse(Console.ReadLine());
    double curr = price * count * days;
    sum += curr;
    Console.WriteLine($"The price for the coffee is: ${curr:f2}");
}

Console.WriteLine($"Total: ${sum:f2}");