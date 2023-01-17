int SumMN(int a, int b)
{
    int res = b;
    if (a != b) res = res + SumMN(a, b - 1);
    return res;
}
Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма числе в промежутке между M и N равна: {SumMN(M, N)}");