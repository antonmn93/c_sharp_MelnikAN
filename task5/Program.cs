﻿// // 7. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа 
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Ввидете 3-х значное число");
int a = int.Parse(Console.ReadLine());

if (a < 0)
{
    Console.WriteLine($"Крайняя цифра введеного числа: {a * -1 % 10}");
}
else
{
    Console.WriteLine($"Крайняя цифра введеного числа: {a % 10}");
}

