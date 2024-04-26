const double PUZZLE = 2.60;
const double TALKING_DOLL = 3;
const double TEDDY_BEAR = 4.10;
const double MINION = 8.20;
const double LORRY = 2;

double excursion = double.Parse(Console.ReadLine());
int numPuzzles = int.Parse(Console.ReadLine());
int numTalkingDolls = int.Parse(Console.ReadLine());
int numTeddyBears = int.Parse(Console.ReadLine());
int numMinions = int.Parse(Console.ReadLine());
int numLorries = int.Parse(Console.ReadLine());

double earnings = numPuzzles * PUZZLE + numTalkingDolls * TALKING_DOLL + numTeddyBears * TEDDY_BEAR + numMinions * MINION + numLorries * LORRY;

if(numPuzzles + numTalkingDolls + numTeddyBears + numMinions + numLorries >= 50)
{
    earnings -= (25 / 100.0) * earnings;
}

earnings -= (10 / 100.0) * earnings;

if(earnings >= excursion)
{
    Console.WriteLine($"Yes! {earnings - excursion:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {excursion - earnings:f2} lv needed.");
}