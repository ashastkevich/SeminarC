int akkerman(int a, int b)
{
    int res = 0;
    if (a == 0) res = b + 1;
    else if (b == 0) res = akkerman(a - 1, 1);
    else if (a * b != 0) res = akkerman(a - 1, akkerman(a, b - 1));
    return res; 
}
Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"akkerman(M, N): {akkerman(M, N)}");