const double PEN_COST = 5.80;
const double MARKER_COST = 7.20;
const double DETERGENT_COST = 1.20;

int numPenPacks = int.Parse(Console.ReadLine());
int numMarkerPacks = int.Parse(Console.ReadLine());
int litresDetergent = int.Parse(Console.ReadLine());
double percentageDiscount = int.Parse(Console.ReadLine()) / 100.0;

double total = numPenPacks * PEN_COST + numMarkerPacks * MARKER_COST + litresDetergent * DETERGENT_COST;

total -= total * percentageDiscount;

Console.WriteLine(total);