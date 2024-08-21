int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int power = n;

int stroked = 0;

while (power >= m)
{
    power -= m;
    stroked++;
    if (power == n * (50 / 100.0)) power /= y;
}

Console.WriteLine(power);
Console.WriteLine(stroked);