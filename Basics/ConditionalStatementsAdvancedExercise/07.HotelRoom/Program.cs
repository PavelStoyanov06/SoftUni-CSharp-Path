string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double pStudio = default, pApart = default;

double dis = default;

switch (month)
{
	case "May":
	case "October":
		pStudio = 50;
		pApart = 65;
		if(nights > 7 && nights <= 14)
		{
			dis = 5 / 100.0;
		}
		else if(nights > 14)
		{
			dis = 30 / 100.0;
		}
		break;
	case "June":
	case "September":
		pStudio = 75.20;
		pApart = 68.70;
        if (nights > 14)
        {
            dis = 20 / 100.0;
        }
        break;
	case "July":
	case "August":
		pStudio = 76;
		pApart = 77;
		break;
	default:
		break;
}

double totalStudio = pStudio * nights;
double totalApart = pApart * nights;

totalStudio -= dis * totalStudio;

if(nights > 14)
{
	totalApart -= 10 / 100.0 * totalApart;
}

Console.WriteLine($"Apartment: {totalApart:f2} lv.{Environment.NewLine}Studio: {totalStudio:f2} lv.");