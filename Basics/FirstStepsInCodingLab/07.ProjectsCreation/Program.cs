const int HOURS_PER_PROJECT = 3;

string architectName = Console.ReadLine();
int numProjects = int.Parse(Console.ReadLine());

int hoursNeeded = numProjects * HOURS_PER_PROJECT;

Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {numProjects} project/s.");