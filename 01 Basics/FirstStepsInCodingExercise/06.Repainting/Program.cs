const double NYLON_COST = 1.50;
const double PAINT_COST = 14.50;
const double PAINT_THINNER_COST = 5.00;

int nylonNeeded = int.Parse(Console.ReadLine());
nylonNeeded += 2;
int litresPaint = int.Parse(Console.ReadLine());
double totalPaint = litresPaint + (10 / 100.0) * litresPaint;
int litresThinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double total = nylonNeeded * NYLON_COST + totalPaint * PAINT_COST + litresThinner * PAINT_THINNER_COST + 0.40;

double workerWage = (30 / 100.0) * total;

total += hours * workerWage;

Console.WriteLine(total);