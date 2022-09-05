//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i+=2)
{
if (i == n || i == n - 1)
    Console.Write(i);
else
    Console.Write(i + ", ");
}