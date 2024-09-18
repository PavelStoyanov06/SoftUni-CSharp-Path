int Factorial (int n)
{
	int mult = 1;

	for (int i = 1; i <= n; i++)
	{
		mult *= i;
	}

	return mult;
}

int input = int.Parse(Console.ReadLine());

int sum = 0;
int temp = input;

while(temp > 0)
{
	int dig = temp % 10;
	sum += Factorial(dig);
	temp /= 10;
}

if(input != sum)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine("yes");
}