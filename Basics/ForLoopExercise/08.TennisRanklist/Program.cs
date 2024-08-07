int tournaments = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());
int points = initialPoints;

int gamesWon = 0;

for (int i = 0; i < tournaments; i++)
{
	string place = Console.ReadLine();
	switch (place)
	{
		case "W":
			points += 2000;
			gamesWon++;
			break;
		case "F":
			points += 1200;
			break;
		case "SF":
			points += 720;
			break;
		default:
			break;
	}
}

Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {(points-initialPoints)/tournaments}");
Console.WriteLine($"{gamesWon/(double)tournaments*100:f2}%");