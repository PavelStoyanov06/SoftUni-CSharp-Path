double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double secondsForMeter = double.Parse(Console.ReadLine());

double time = distance * secondsForMeter;

double extraTime = Math.Floor(distance / 15) * 12.5;

time += extraTime;

if (time < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {time - record:f2} seconds slower.");
}