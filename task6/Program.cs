Console.Clear();
Console.WriteLine("Введите любое число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 > 0)
{
    Console.WriteLine("Это число не является четным");
}
else
{
    Console.WriteLine("Это число является четным");
}