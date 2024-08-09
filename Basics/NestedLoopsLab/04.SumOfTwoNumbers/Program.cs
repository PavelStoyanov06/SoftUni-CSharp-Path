int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magic = int.Parse(Console.ReadLine());

int count = 0;

for (int i = start; i <= end; i++)
{
	for (int j = start; j <= end; j++)
	{
		count++;
		if(magic == i + j)
		{
            Console.WriteLine($"Combination N:{count} ({i} + {j} = {magic})");
			Environment.Exit(0);
        }
	}
}

Console.WriteLine($"{count} combinations - neither equals {magic}");