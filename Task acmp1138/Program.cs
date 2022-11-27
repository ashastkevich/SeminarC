Console.Clear();
Console.WriteLine("Введите числа:");
int n = int.Parse(Console.ReadLine());
int max = n;
n = int.Parse(Console.ReadLine());
int max2 = n;
 do {
    if (n>max) {
        max2 = max;
        max = n;
    }
    else if (n < max && n > max2)
        max2 = n;
    n = int.Parse(Console.ReadLine());
} while (n != 0);
Console.WriteLine($"Второй максимум: {max2}");