int w = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

int volume = w * l * h;

int count = 0;

string input = Console.ReadLine();

while(count < volume && input != "Done")
{
    count += int.Parse(input);
    input = Console.ReadLine();
}

if(count > volume)
{
    Console.WriteLine($"No more free space! You need {count - volume} Cubic meters more.");
}
else
{
    Console.WriteLine($"{volume - count} Cubic meters left.");
}