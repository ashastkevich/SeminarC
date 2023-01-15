void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble()*(10-1)+1;
}

double CountDiff (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
        if (max < array[i])
            max = array[i];
    }
    return max-min;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: {string.Join(",      ", array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {CountDiff(array)}");