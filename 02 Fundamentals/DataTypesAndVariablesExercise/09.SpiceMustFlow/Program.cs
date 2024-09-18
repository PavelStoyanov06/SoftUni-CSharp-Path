int source = int.Parse(Console.ReadLine());

int days = 0;
int total = 0;
while (source >= 100)
{
    days++;
    total += source - 26;
    source -= 10;
    if(source < 100)
    {
        total -= 26;
    }
}
Console.WriteLine(days);
Console.WriteLine(total);