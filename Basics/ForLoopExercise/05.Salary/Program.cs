int n = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	string input = Console.ReadLine();
	switch (input)
	{
		case "Facebook":
			salary -= 150;
			break;
		case "Instagram":
			salary -= 100;
			break;
		case "Reddit":
			salary -= 50;
			break;
		default:
			break;
	}
	if(salary <= 0)
	{
        Console.WriteLine("You have lost your salary.");
		Environment.Exit(0);
    }
}

Console.WriteLine(salary);