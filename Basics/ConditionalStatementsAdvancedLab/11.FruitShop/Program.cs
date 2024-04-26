﻿string fruit = Console.ReadLine();
string day = Console.ReadLine();
double amount = double.Parse(Console.ReadLine());

double price = 0;

switch (day)
{
	case "Monday":
	case "Tuesday":
	case "Wednesday":
	case "Thursday":
	case "Friday":
		switch (fruit)
		{
			case "banana":
				price = 2.5;
				break;
			case "apple":
				price = 1.2;
				break;
			case "orange":
				price = 0.85;
				break;
			case "grapefruit":
				price = 1.45;
				break;
			case "kiwi":
				price = 2.7;
				break;
			case "pineapple":
				price = 5.5;
				break;
			case "grapes":
				price = 3.85;
				break;
			default:
                Console.WriteLine("error");
                Environment.Exit(1);
                break;
		}
		break;
	case "Saturday":
	case "Sunday":
        switch (fruit)
        {
            case "banana":
                price = 2.7;
                break;
            case "apple":
                price = 1.25;
                break;
            case "orange":
                price = 0.9;
                break;
            case "grapefruit":
                price = 1.6;
                break;
            case "kiwi":
                price = 3;
                break;
            case "pineapple":
                price = 5.6;
                break;
            case "grapes":
                price = 4.2;
                break;
            default:
                Console.WriteLine("error");
                Environment.Exit(1);
                break;
        }
        break;
	default:
        Console.WriteLine("error");
		Environment.Exit(1);
        break;
}

double total = amount * price;

Console.WriteLine($"{total:f2}");