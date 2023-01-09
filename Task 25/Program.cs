
Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int i = 1;
int result = A;
while (i < B)
{
    result = result * A;
    i++;
}
Console.WriteLine(result);