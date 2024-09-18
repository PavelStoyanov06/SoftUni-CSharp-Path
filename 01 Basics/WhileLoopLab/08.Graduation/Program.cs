string name = Console.ReadLine();

int clas = 1;

int fails = 0;

double total = 0;

while(clas <= 12)
{
    double grade = double.Parse(Console.ReadLine());
    total += grade;
    if(grade < 4)
    {
        if(fails == 1)
        {
            Console.WriteLine($"{name} has been excluded at {clas} grade");
            Environment.Exit(0);
        }
        fails++;
        continue;
    }
    fails = 0;
    clas++;
}

Console.WriteLine($"{name} graduated. Average grade: {total/12.0:f2}");