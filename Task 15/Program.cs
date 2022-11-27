Console.Clear();
Console.Write("Введите день недели: ");
int N = int.Parse(Console.ReadLine());
if (N==6 || N==7)
    Console.WriteLine("Да");
else 
    Console.WriteLine("Нет");
