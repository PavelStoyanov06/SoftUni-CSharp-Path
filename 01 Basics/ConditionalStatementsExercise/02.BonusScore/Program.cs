int startingScore = int.Parse(Console.ReadLine());

double bonusPoints = 0;

if(startingScore <= 100)
{
    bonusPoints = 5;
}
else if(startingScore > 100 && startingScore <= 1000)
{
    bonusPoints = (20 / 100.0) * startingScore;
}
else if(startingScore > 1000)
{
    bonusPoints = (10 / 100.0) * startingScore;
}

if(startingScore % 2 == 0)
{
    bonusPoints++;
}

if(startingScore % 10 == 5)
{
    bonusPoints += 2;
}

Console.WriteLine(bonusPoints);

double totalPoints = bonusPoints + startingScore;

Console.WriteLine(totalPoints);