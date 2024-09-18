int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());

TimeOnly time = new TimeOnly(hour, minute);

time = time.AddMinutes(15);

Console.WriteLine($"{time.Hour}:{time.Minute:d2}");