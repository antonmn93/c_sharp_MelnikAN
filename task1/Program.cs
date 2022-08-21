// Напишите программу,
// 1. которая на вход принимает два числа 
// 2.и проверяет, является ли первое число квадратом второго..
// a = 25, b = 5 - > да 
// a = 2; b = 10 - > нет
// a = 9; b = - 3 - > да
// a = -3; b = 9 - > нет

Console.Write ("Введите целое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите еще одно число: ");
int b = Convert.ToInt32(System.Console.ReadLine()); 
if(b*b == a) Console.WriteLine($"число {a} является квадратом числа {b}");
else Console.WriteLine($"число {a} Не является квадратом числа {b}");