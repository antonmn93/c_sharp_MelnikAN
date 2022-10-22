// Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдает его квадрат (число 
// умноженное на само себя).
// Например:
// 4->16
// -3->9
// -7->49

Console.WriteLine("Введите целое число");
int nun = Convert.ToInt32(Console.ReadLine());
int square = nun * nun;
Console.WriteLine($"Квадрат числа {nun} = {square}");

