// // 7. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа 
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трех значное чило");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    Console.WriteLine($"Последняя цифра трехзначного числа {a * - 1 % 10}");
}
else 
{
    Console.WriteLine($"Последняя цифра трехзначного числа {a % 10}");
}