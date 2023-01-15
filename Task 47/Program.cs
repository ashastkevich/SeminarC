void InputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*(20-1)+1;
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] size = Console.ReadLine().Split(" ");
int row = int.Parse(size[0]);
int column = int.Parse(size[1]);
double[,] array = new double[row,column];
InputArray(array);
