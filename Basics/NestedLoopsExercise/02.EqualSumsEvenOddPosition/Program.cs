int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
    int temp = i;
    int sumEven = 0, sumOdd = 0;
    int counter = 0;
    while(temp > 0)
    {
        if(counter % 2 == 0)
        {
            sumEven += temp % 10;
        } 
        else
        {
            sumOdd += temp % 10;
        }
        counter++;
        temp/=10;
    }
    if(sumEven == sumOdd)
    {
        Console.Write(i + " ");
    }
}