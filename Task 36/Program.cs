void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1,100);
}

int CountSum (int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
            result = result + array[i];
    }
    return result;
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: {string.Join(",      ", array)}");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве: {CountSum(array)}");
