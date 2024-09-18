int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentageTaken = double.Parse(Console.ReadLine()) / 100.0;

double totalVolume = length * width * height;
totalVolume -=  percentageTaken * totalVolume;

Console.WriteLine(totalVolume / 1000);