// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ShowEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] GenerateRandomArray(int length, int fistNumber, int lastNumber)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(fistNumber, lastNumber + 1);
    return array;
}

int[] array = GenerateRandomArray(5, 100, 1000);
Console.Write($"[{string.Join(",", array)}]");
Console.WriteLine($" -> {ShowEvenNumbers(array)}");
