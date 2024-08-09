string input = Console.ReadLine();

int student = 0, standard = 0, kid = 0;

while(input != "Finish")
{
    int space = int.Parse(Console.ReadLine());
	int taken = 0;
	for (int i = 0; i < space; i++)
	{
		string ticket = Console.ReadLine();
		if (ticket == "student")
		{
			student++;
		}
		else if (ticket == "standard")
		{
			standard++;
		}
		else if (ticket == "kid")
		{
			kid++;
		}
		else if(ticket == "End")
		{
			break;
		}
		taken++;
	}
    Console.WriteLine($"{input} - {taken/(double)space*100:f2}% full.");
	input = Console.ReadLine();
}

int total = kid + standard + student;

Console.WriteLine($"Total tickets: {total}");
Console.WriteLine($"{(double)student/total*100:f2}% student tickets.");
Console.WriteLine($"{(double)standard/total*100:f2}% standard tickets.");
Console.WriteLine($"{(double)kid/total*100:f2}% kids tickets.");