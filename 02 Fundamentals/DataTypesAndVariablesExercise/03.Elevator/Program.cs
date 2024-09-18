int people = int.Parse(Console.ReadLine());
int cap = int.Parse(Console.ReadLine());

int res = people / cap;

if (people % cap != 0) res++;

Console.WriteLine(res);