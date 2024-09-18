int n = int.Parse(Console.ReadLine());

int counter = 1;

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= i; j++)
	{
		Console.Write($"{counter} ");
		if(counter == n)
		{
			Environment.Exit(0);
		}
		counter++;
	}
    Console.WriteLine();
}