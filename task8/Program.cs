﻿Console.Clear();
Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
for (int i =2; i <= num; i= i+2)
    { 
        Console.Write(i);
        Console.Write(",");
    }