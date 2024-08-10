int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

TimeOnly time = new TimeOnly(hours, minutes);

time = time.AddMinutes(30);

Console.WriteLine(time.ToString("H:mm"));