Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int result = 0;
for (int i = 0; i < n.Length; i++)
{
    result = result + int.Parse(n[i].ToString());
}
Console.WriteLine(result);