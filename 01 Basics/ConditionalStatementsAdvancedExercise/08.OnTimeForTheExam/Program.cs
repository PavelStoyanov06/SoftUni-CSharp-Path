int examHour = int.Parse(Console.ReadLine());
int examMin = int.Parse(Console.ReadLine());

TimeOnly examTime = new TimeOnly(examHour, examMin);

int arriveHour =  int.Parse(Console.ReadLine());
int arriveMin = int.Parse(Console.ReadLine());

TimeOnly arriveTime = new TimeOnly(arriveHour, arriveMin);

TimeSpan diff;

if(examTime > arriveTime)
{
    diff = examTime - arriveTime;
}
else
{
    diff = arriveTime - examTime;
}

if (examTime.CompareTo(arriveTime) < 0)
{
    Console.WriteLine("Late");
    if(diff.TotalMinutes < 60)
    {
        Console.WriteLine($"{diff.Minutes} minutes after the start");
    }
    else
    {
        if (diff.Minutes < 10)
        {
            Console.WriteLine($"{diff.Hours}:0{diff.Minutes} hours after the start");
        }
        else
        {
            Console.WriteLine($"{diff.Hours}:{diff.Minutes} hours after the start");
        }
    }
}
else
{
    if(diff.TotalMinutes <= 30)
    {
        Console.WriteLine("On time");
        if(diff.TotalMinutes != 0)
        {
            Console.WriteLine($"{diff.Minutes} minutes before the start");
        }
    }
    else
    {
        Console.WriteLine("Early");
        if (diff.TotalMinutes < 60)
        {
            Console.WriteLine($"{diff.Minutes} minutes before the start");
        }
        else
        {
            if(diff.Minutes < 10)
            {
                Console.WriteLine($"{diff.Hours}:0{diff.Minutes} hours before the start");
            }
            else
            {
                Console.WriteLine($"{diff.Hours}:{diff.Minutes} hours before the start");
            }
        }
    }
}