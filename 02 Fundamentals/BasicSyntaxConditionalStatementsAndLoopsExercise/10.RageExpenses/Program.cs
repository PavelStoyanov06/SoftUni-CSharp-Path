int lostGames = int.Parse(Console.ReadLine());
double headset = double.Parse(Console.ReadLine());
double mouse = double.Parse(Console.ReadLine());
double keyboard = double.Parse(Console.ReadLine());
double display = double.Parse(Console.ReadLine());

double expenses = (lostGames / 2) * headset + (lostGames / 3) * mouse + (lostGames / 6) * keyboard + (lostGames/12) * display;

Console.WriteLine($"Rage expenses: {expenses:f2} lv.");