//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int GenerateRandomNumbers()
{
    int n = new Random().Next(100, 1000);
    return n;
}

void CompraiseNumbers()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine(n);
    Console.Write(Convert.ToString(n)[1]);
}

CompraiseNumbers();