//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//     0, 7, 8, -2, -2 -> 2

int M = new Random().Next(1, 10);
int count = 0;
Console.WriteLine("Введите числа: ");
for (int i = 1; i <= M; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++; 
}
Console.WriteLine($"количество элементов больше нуля = {count}");



