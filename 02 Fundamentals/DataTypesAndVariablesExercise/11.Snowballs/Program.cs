﻿using System.Numerics;

int n = int.Parse(Console.ReadLine());

BigInteger maxValue = BigInteger.MinusOne;
int maxSnow = 0;
int maxTime = 0;
int maxQuality = 0;

for (int i = 0; i < n; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
    if(maxValue < snowballValue)
    {
        maxValue = snowballValue;
        maxSnow = snowballSnow;
        maxTime = snowballTime;
        maxQuality = snowballQuality;
    }
}

Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");