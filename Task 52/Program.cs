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
void Average (int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i,j];
        }
        Console.WriteLine(result/array.GetLength(1));
        result = 0;
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] size = Console.ReadLine().Split(" ");
int row = int.Parse(size[0]);
int column = int.Parse(size[1]);
int[,] array = new int[row,column];
InputArray(array);
Average(array);
