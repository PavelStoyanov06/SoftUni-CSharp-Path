double deposit = double.Parse(Console.ReadLine());
int interval = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine()) / 100.0;

double total = deposit + interval * ((deposit * percentage) / 12);

Console.WriteLine(total);
