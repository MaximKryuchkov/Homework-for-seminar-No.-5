// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size, int beginRange = -99, int endRange = 100)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(beginRange, endRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(",  ", array));
}

int SumIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Clear();

int size = ReadInt("Задайте одномерный массив: ");
int[] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {SumIndex(array)}");
