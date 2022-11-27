Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int temp = N;
int len = 1;
while (temp/10>0) {
    len=len*10;
    temp=temp/10;
}
if (len>10)
    Console.WriteLine($"Третья цифра числа: {N/(len/100)%10}");
else 
    Console.WriteLine("Третьей цифры нет");
