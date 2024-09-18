string seriesName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
double breakLength = int.Parse(Console.ReadLine());

double lunchTime = (1 / 8.0) * breakLength;
double restTime = (1 / 4.0) * breakLength;

breakLength -= lunchTime + restTime;

if(breakLength >= episodeLength)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(breakLength - episodeLength)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLength - breakLength)} more minutes.");
}