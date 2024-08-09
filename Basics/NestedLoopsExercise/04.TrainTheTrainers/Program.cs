int n = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

double totalGrade = 0;
int counter = 0;

while(input != "Finish")
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += double.Parse(Console.ReadLine());
    }
    Console.WriteLine($"{input} - {sum/n:f2}.");
    totalGrade += sum/n;
    counter++;
    input = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {totalGrade/counter:f2}.");