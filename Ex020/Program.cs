// Задача 54: Задайте двумерный массив. Напишите программу 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив: 1 4 7 2         7 4 2 1
//                         5 9 2 3    ->   9 5 3 2
//                         8 4 2 4         8 4 4 2

/* Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
FillArrayRandomNumbers(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(array);
PrintArray(array);

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
} */



// ----------------------------------------------------------------------
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:    1 4 7 2     14
//                           5 9 2 3     19
//                           8 4 2 4     18
//                           5 2 6 7     20

//Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

/* Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];

FillArrayRandomNumbers(array);
Console.WriteLine();
PrintArray(array);

int minSum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        indexLine++;
    } 
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: "+ (indexLine));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
} */


// -------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

//Например, даны 2 матрицы:         Результирующая матрица будет:
//    2 4 | 3 4                         18 20
//    3 2 | 3 3                         15 18

/* void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int size = InputInt("размер матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);

int[,] matrixC = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
            matrixC[i, j] += (matrixA[i, k] * matrixB[k, j]);
    }
}

Console.WriteLine("Матрица А");
PrintArray(matrixA);

Console.WriteLine("Матрица B");
PrintArray(matrixB);

Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC); */



// -------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

//Массив размером 2 x 2 x 2
//   66(0,0,0) 25(0,1,0)
//   34(1,0,0) 41(1,1,0)
//   27(0,0,1) 90(0,1,1)
//   26(1,0,1) 55(1,1,1)

// ********* ЭТУ ЗАДАЧУ НЕ СМОГЛА РЕШИТЬ, КАКОЙ ОНА ДОЛЖНА БЫТЬ ПОНИМАЮ
// НО НЕ МОГУ РАЗОБРАТЬСЯ КАК РЕАЛИЗОВАТЬ ПРАВИЛЬНО***********

/* Console.WriteLine("введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] Array = new int[x, y, z];
FillArrayRandomNumbers(Array);
CreateArray(Array);

void FillArrayRandomNumbers(int[,,] Array);
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
                Console.WriteLine($"[{i},{j},{k}] - {Array[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CreateArray(int[,,] Array);
{
    int number;
    int[] temp = new int[Array.GetLength(0) * Array.GetLength(1) * Array.GetLength(2)];
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(1, 11);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(1, 11);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < Array.GetLength(0); x++)
    {
        for (int y = 0; y < Array.GetLength(1); y++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Array[x, y, z] = temp[count];
                count++;
            }
        }
    }
} */








// ------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//   01 02 03 04
//   12 13 14 05
//   11 16 15 06
//   10 09 08 07

/* Console.WriteLine("заполнение спирально массива 4 на 4: ");
int n = 4;
int[,] array = new int[4, 4];

int num = 1;
int i = 0;
int j = 0;

while (num <= n * n)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < n - 1)  // GetLength(1)
        j++;
    else if (i < j && i + j >= n - 1) // GetLength(0)
        i++;
    else if (i >= j && i + j > n - 1) // GetLength(1)
        j--;
    else --i;
    ++num;
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
} */

