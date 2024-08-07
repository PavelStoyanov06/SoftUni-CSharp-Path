int n = int.Parse(Console.ReadLine());

int musala = 0, monblan = 0, kil = 0, k2 = 0, everest = 0;

int total = 0;

for (int i = 0; i < n; i++)
{
    int count = int.Parse(Console.ReadLine());
    total += count;
    if (count <= 5)
    {
        musala+=count;
    }
    else if (count >= 6 && count <= 12)
    {
        monblan+=count;
    }
    else if (count >= 13 && count <= 25)
    {
        kil += count;
    }
    else if (count >= 26 && count <= 40)
    {
        k2+=count;
    }
    else if(count >= 41)
    {
        everest += count;
    }
}

Console.WriteLine($"{musala/(double)total*100:f2}%");
Console.WriteLine($"{monblan/(double)total*100:f2}%");
Console.WriteLine($"{kil/(double)total *100:f2}%");
Console.WriteLine($"{k2/(double)total *100:f2}%");
Console.WriteLine($"{everest/(double)total *100:f2}%");