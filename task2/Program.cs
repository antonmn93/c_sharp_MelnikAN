// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 - > Пятница

Console.Write("Введите целое число от 1 до 7 ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 1) Console.Write("Понедельниик");
else if(a == 2) Console.Write("Вторник");
else if(a == 3) Console.Write("Среда");
else if(a == 4) Console.Write("Четверг");
else if(a == 5) Console.Write("Пятница");
else if(a == 6) Console.Write("Суббота");
else if(a == 7) Console.Write("Ввоскресенье");
else Console.Write("Числе не в интервале от 1 до 7");
