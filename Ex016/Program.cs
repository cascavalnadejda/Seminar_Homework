// ДОП ЗАДАЧА
// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность
// (сдвиг - циклический) на |K| элементов вправо, 
// если K – положительное и влево, если отрицательное.

//Первая строка входного файла INPUT.TXT содержит натуральное число N,
// во второй строке записаны N целых чисел Ai, а в последней – целое число K.
// (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
int[] arrayResult = new int[n];

for (int i = 0; i < arrayFirst.Length; i++)
    arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("[" + string.Join(", ", arrayFirst) + "]");

int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        arrayResult[i] = arrayFirst[arrayFirst.Length - k + i];
    Console.WriteLine("[" + string.Join(", ", arrayResult) + "]");

    for (int i = 0; i < n - k; i++)
        arrayResult[k + i] = arrayFirst[i];
}
else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        arrayResult[arrayFirst.Length - k + i] = arrayFirst[i];
    Console.WriteLine("[" + string.Join(", ", arrayResult) + "]");

    for (int i = 0; i < n - k; i++)
        arrayResult[i] = arrayFirst[k + i];
}

Console.WriteLine("[" + string.Join(", ", arrayResult) + "]");

