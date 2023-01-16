void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, k]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] BubbleSort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[i] < array[k])
            {
                temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }                   
        }            
    }
    return array;
}

int[] GetRow(int[,] matrix, int rowNumber)
{
    return Enumerable.Range(0, matrix.GetLength(1)).Select(x => matrix[rowNumber, x]).ToArray();
}

Console.Clear();

Console.Write("Введите размер матрицы: ");
int[] matrixSize = Console.ReadLine().Split(" ").Select(n => int.Parse(n)).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

InputMatrix(matrix);


int[] array = new int[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    array = GetRow(matrix, i);
    array = BubbleSort(array);
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        matrix[i, k] = array[k];
        Console.Write($"{matrix[i, k]} \t");
    }
    Console.WriteLine(); 
}