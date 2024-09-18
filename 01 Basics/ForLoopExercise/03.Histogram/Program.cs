int n = int.Parse(Console.ReadLine());

int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

for (int i = 0; i < n; i++)
{
    int curr = int.Parse(Console.ReadLine());
    if(curr < 200)
    {
        p1++;
    }
    else if(curr >= 200 && curr < 400)
    {
        p2++;
    }
    else if(curr >= 400 && curr < 600)
    {
        p3++;
    }
    else if( curr >= 600 && curr < 800)
    {
        p4++;
    }
    else
    {
        p5++;
    }
}

Console.WriteLine($"{p1 / (double)n * 100:f2}%");
Console.WriteLine($"{p2 / (double)n * 100:f2}%");
Console.WriteLine($"{p3 / (double)n * 100:f2}%");
Console.WriteLine($"{p4 / (double)n * 100:f2}%");
Console.WriteLine($"{p5 / (double)n * 100:f2}%");