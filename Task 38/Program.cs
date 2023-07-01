// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] FillArray(int size, int beginRange = 0, int endRange = 100)
{
    double[] array = new double[size];
    Random rand = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(beginRange, endRange) + rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine(string.Join(",  ", array));
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

Console.Clear();

int size = ReadInt("Задайте массив вещественных чисел: ");
double[] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine($"Max элемент массива = {MinElement(array)}");
System.Console.WriteLine($"Min элемент массива = {MaxElement(array)}");
double diff = MaxElement(array) - MinElement(array);
System.Console.WriteLine($"Разница между Max и Min элементами массива = {Math.Round(diff, 2)}");
