Console.Clear();
Console.Write("Введите число: ");
string N = Console.ReadLine();
int N_reverse=0;
for (int i = N.Length - 1; i >= 0; i--)
{
    N_reverse = N_reverse + Convert.ToInt32(int.Parse(N[i].ToString()) * Math.Pow(10,i));
}
//Console.WriteLine(N_reverse);
if (N_reverse==int.Parse(N))
    Console.WriteLine("Да");
else
    Console.WriteLine("No");