int w = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

int area = w *  h;

int count = 0;
string input = Console.ReadLine();
while(count < area && input != "STOP")
{
    count += int.Parse(input);
    input = Console.ReadLine();
}

if(count > area)
{
    Console.WriteLine("No more cake left! You need {0} pieces more.", count-area);
}
else
{
    Console.WriteLine("{0} pieces are left.", area-count);
}