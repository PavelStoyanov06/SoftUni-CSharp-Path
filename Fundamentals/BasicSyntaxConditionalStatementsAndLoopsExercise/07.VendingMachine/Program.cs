double[] valid = { 0.1, 0.2, 0.5, 1, 2 };

string input = Console.ReadLine();

double sum = 0;

while (input != "Start")
{
    double coin = double.Parse(input);
    if (!valid.Contains(coin))
    {
        Console.WriteLine("Cannot accept {0}", coin);
        input = Console.ReadLine();
        continue;
    }
    sum+= coin;
    input = Console.ReadLine();
}

input = Console.ReadLine();

while (input != "End")
{
    double price = 0;
    bool validProduct = true;
    switch (input)
    {
        case "Nuts":
            price = 2;
            break;
        case "Water":
            price = 0.7;
            break;
        case "Crisps":
            price = 1.5;
            break;
        case "Soda":
            price = 0.8;
            break;
        case "Coke":
            price = 1;
            break;
        default:
            Console.WriteLine("Invalid product");
            validProduct = false;
            break;
    }

    if(sum >= price && validProduct)
    {
        Console.WriteLine("Purchased {0}", input.ToLower());
        sum -= price;
    }
    else if(sum < price)
    {
        Console.WriteLine("Sorry, not enough money");
    }

    input = Console.ReadLine();
}

Console.WriteLine("Change: {0}", string.Format("{0:f2}", sum));