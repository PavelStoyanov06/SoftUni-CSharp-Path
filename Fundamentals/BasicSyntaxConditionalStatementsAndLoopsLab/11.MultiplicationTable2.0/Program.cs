int num = int.Parse(Console.ReadLine());
int start = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{num} X {start} = {num * start}");
    start++;
}
while (start <= 10);