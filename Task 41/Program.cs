Console.Clear();
Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());
int Number = 0;
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write("Введите число: ");
    if (int.Parse(Console.ReadLine()) > 0)
        count++;
}
Console.WriteLine($"Количество чисел больше нуля: {count}");