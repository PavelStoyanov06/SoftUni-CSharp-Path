int numPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int numDays = int.Parse(Console.ReadLine());

int numHours = numPages / pagesPerHour / numDays;

Console.WriteLine(numHours);