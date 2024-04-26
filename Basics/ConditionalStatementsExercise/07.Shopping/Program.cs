const double VIDEO_CARD_PRICE = 250;

double budget = double.Parse(Console.ReadLine());
int numVideoCards = int.Parse(Console.ReadLine());

double videoCardTotal = numVideoCards * VIDEO_CARD_PRICE;

int numProcessors = int.Parse(Console.ReadLine());

int numRAM = int.Parse(Console.ReadLine());

double processorPrice = (35 / 100.0) * videoCardTotal;
double ramPrice = (10 / 100.0) * videoCardTotal;

double total = videoCardTotal + processorPrice * numProcessors + ramPrice * numRAM;

if(numProcessors < numVideoCards)
{
    total -= total * (15 / 100.0);
}

if(budget >= total)
{
    Console.WriteLine($"You have {budget - total:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {total - budget:f2} leva more!");
}