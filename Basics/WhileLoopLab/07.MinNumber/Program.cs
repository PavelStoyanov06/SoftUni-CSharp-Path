﻿string input = Console.ReadLine();

int min = int.MaxValue;

while (input != "Stop")
{
    min = Math.Min(min, int.Parse(input));
    input = Console.ReadLine();
}

Console.WriteLine(min);