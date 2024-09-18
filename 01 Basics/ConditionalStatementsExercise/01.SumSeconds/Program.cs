int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalSeconds = firstTime + secondTime + thirdTime;

int hours = totalSeconds / 60;

int minutes = totalSeconds % 60;

Console.WriteLine($"{hours}:{minutes:d2}");