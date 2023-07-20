// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumUnevenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

int[] GenerateRandomArray(int length, int fistNumber, int lastNumber)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fistNumber, lastNumber + 1);
    }
    return array;
}

int[] array = GenerateRandomArray(4, -10, 10);
Console.Write($"[{string.Join(",", array)}]");
Console.WriteLine($" -> {GetSumUnevenPosition(array)}");
