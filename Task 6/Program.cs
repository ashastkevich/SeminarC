Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine("Да");
else 
    Console.WriteLine("Нет");