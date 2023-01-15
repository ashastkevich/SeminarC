void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Random rnd = new Random();
int row = rnd.Next(1,10);
int column = rnd.Next(1,10);
int[,] array = new int[row,column];
InputArray(array);
Console.Write("Введите позицию искомого эелемента: ");
string[] size = Console.ReadLine().Split(" ");
int X = int.Parse(size[0]);
int Y = int.Parse(size[1]);
if ((X <= row) & (Y <= column))
    Console.WriteLine($"{array[X-1,Y-1]}");
else
    Console.WriteLine("Такой позиции в массиве нет.");