void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                matrix[i, k, j] = new Random().Next(0, 100);
                Console.Write($"{matrix[i, k, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();

int[,,] matrix = new int[2, 2, 2];

InputMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        for (int j = 0; j < matrix.GetLength(2); j++)
        {
            Console.Write($"{matrix[i, k, j]} ({i},{k},{j}) \t");
        }
        Console.WriteLine();
    }
}