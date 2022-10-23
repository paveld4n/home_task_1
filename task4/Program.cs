Console.WriteLine("введите три чиcла");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Самое большое число {num1}");
}
else if (num2 >= num1 && num2 > num3)
{
    Console.WriteLine($"Самое большое число {num2}");
}
else
{
    Console.WriteLine($"Самое большое число {num3}");
}

