string town = Console.ReadLine();
double salesVolume = double.Parse(Console.ReadLine());

double percent = 0;

if (salesVolume >= 0 && salesVolume <= 500)
{
    switch (town)
    {
        case "Sofia":
            percent = 5;
            break;
        case "Varna":
            percent = 4.5;
            break;
        case "Plovdiv":
            percent = 5.5;
            break;
        default:
            Console.WriteLine("error");
            Environment.Exit(1);
            break;
    }
}
else if (salesVolume > 500 && salesVolume <= 1000)
{
    switch (town)
    {
        case "Sofia":
            percent = 7;
            break;
        case "Varna":
            percent = 7.5;
            break;
        case "Plovdiv":
            percent = 8;
            break;
        default:
            Console.WriteLine("error");
            Environment.Exit(1);
            break;
    }
}
else if (salesVolume > 1000 && salesVolume <= 10000)
{
    switch (town)
    {
        case "Sofia":
            percent = 8;
            break;
        case "Varna":
            percent = 10;
            break;
        case "Plovdiv":
            percent = 12;
            break;
        default:
            Console.WriteLine("error");
            Environment.Exit(1);
            break;
    }
}
else if (salesVolume > 10000)
{
    switch (town)
    {
        case "Sofia":
            percent = 12;
            break;
        case "Varna":
            percent = 13;
            break;
        case "Plovdiv":
            percent = 14.5;
            break;
        default:
            Console.WriteLine("error");
            Environment.Exit(1);
            break;
    }
}
else
{
    Console.WriteLine("error");
    Environment.Exit(1);
}

double commission = salesVolume * (percent / 100.0);

Console.WriteLine($"{commission:f2}");