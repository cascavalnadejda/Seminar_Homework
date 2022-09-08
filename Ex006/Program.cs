// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
    if (n < 99)
        Console.WriteLine("Третья цифра отсутствует");
    else
        Console.WriteLine(Convert.ToString(n)[2]);
