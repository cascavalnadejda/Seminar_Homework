// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//     M = 1; N = 15 -> 120
//     M = 4; N = 8. -> 30

/* Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Result(m, n);

void Result(int m, int n)
{
    Console.Write(Summ(m - 1, n));
}

int Summ(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Summ(m, n);
        return res;
    }
} */


//--------------------------------------------------------------

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//       m = 2, n = 3 -> A(m,n) = 9
//       m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction = Akkerman(m, n);
Console.WriteLine();
Console.WriteLine($"Функция Аккермана = {AkkermanFunction} ");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}