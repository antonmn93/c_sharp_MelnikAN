﻿// //Задачо 0
// Напишите программу, которая
// 1. на вход принимает число
// 2. и выдает его квадрат (число
// умноженное на само себя).
// Например: 4->16, -3->9 -7->49

 // Console.WriteLine("Введите целое число");
// int nun = Convert.ToInt32(Console.ReadLine());
// int square = nun * nun;
// Console.Write($"Квадрат числа {nun} = {square}");

// Решение в группах:

// Задача 1.
// Напишите программу
// 1. которая на вход принимает два числа
// 2.и проверяет, является ли первое число квадратом второго..
// // a = 25, b = 5 - > да, // a = 2; b = 10 - > нет
// // a = 9; b = - 3 - > да, // a = -3; b = 9 - > нет

// Console.WriteLine("Введите целое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите еще одно число");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b*b == a) Console.WriteLine($"Число {a} является квадратом числа {b}");
// else Console.WriteLine($"Число {a} не является квадратом числа {b}");

// Описание кода:
// 1.Выводим на экран приглашение пользователю ввести целое число;
// 2.создаем переменную "a" целочисленного типа int для хранение чиисла, который ввел пользователь в памяти компьютера, переводим данную строку в тип int32 битную;
// 3.Выводим на экран приглашение пользователю ввести еще одно целое число;
// 2. также создаем переменную "b" целочисленного типа int для хранение чиисла, который ввел пользователь в памяти компьютера, переводим данную строку в тип int32 битную
// 3.используем условный оператор, который проверяет условие, равняется ли переменная "a" квадратом переменной "b".
// 4.Если условие верно, то выводится строка "Число {a} является квадратом числа {b}"
// 5.Если условие неверно, то выводится строка "Число {a} не является квадратом числа {b}"

// Задача 3.
// // Напишите программу, которая будет выдавать
// // название дня недели по заданному номеру.
// // 3 -> Среда
// // 5 - > Пятница

// Console.WriteLine("Введите чтисло в диапозоне от 1 до 7 ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a == 1) Console.WriteLine("Понедельник");
// else if (a == 2) Console.WriteLine("Вторник");
// else if(a == 3) Console.WriteLine("Среда");
// else if(a == 4) Console.WriteLine("Четверг");
// else if(a == 5) Console.WriteLine("Пятница");
// else if(a == 6) Console.WriteLine("Суббота");
// else if(a == 7) Console.WriteLine("Ввоскресенье");
// else Console.Write("Число не в диапозоне от 1 до 7");

// Описание кода:
// 1.Выводим на экран приглашение пользователю ввести целое число;
// 2.создаем переменную "a" целочисленного типа int для хранение чиисла, который ввел пользователь в памяти компьютера, переводим данную строку в тип int32 битную;
// 3.используем условный оператор, который проверяет условие, которое заключается в следующем, если переменная "a" = от 1 до 7, то на экран выводится строка с названием дня недели от Понедельника до Воскресенья
// если нет, то на экран выводится, что число не в диапозоне от 1 до 7

// Задача 5. Напишите программу, которая на вход принимеает 
// одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 - > -4,-3,-2,-1, 0,1,2,3,4

// Первый вариант

// 1.Выводим на экран приглашение пользователю ввести целое число;
// 2.создаем переменную nun целочисленного типа int для хранение чиисла, который ввел пользователь в памяти компьютера, переводим данную строку в тип int32 битную;
// 3.создаем переменную nun2 приравниваем ее к -nun, то есть, делаем число, которое ввел пользователь отрицательным;
// 4.с помощью цикла while (задаем условие, что бы это условие выполнялось до тех пор, пока nun2 не будет <= nun);
// 5.Вывод на Console значение nun2+ " ";
// ставим счетчик, прибавляем 1, после каждого прохода.

// Console.WriteLine("Введите целое число");
// int nun = Convert.ToInt32(Console.ReadLine());
// int nun2 = - nun;
// while(nun2 <= nun)
// {
//     Console.Write(nun2+ " ");
//     nun2++;
// }

// Второй вариант 
// Console.Write("Напишите целое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вывод чисел в промежутке от N до N");
// for (int i = -a; i <= a; i++)
// {
//     Console.Write(i + " ");
// }

// В консоли выводим строчку "Напишите число"
// Создаем переменную и тут же запрашиваем в консоли полязователя ввести цифру, которая помещается в эту переменную 
// В консоли выводим строчку "Вывод чисел в промежутке от N до N"
// Используя цикл, мы создаем переменную  i, которая будет ровна отрицательному числу a, 
// которое ввел пользователь и пока i будет <= a, мы делаем цикл и после прохождения операции мы к i прибавляем 1


// Console.WriteLine("Ввидете 3-х значное число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a < 0)
// {
//     Console.WriteLine($"Крайняя цифра введеного числа: {a * -1 % 10}");
// }
// else
// {
//     Console.WriteLine($"Крайняя цифра введеного числа: {a % 10}");
// }

// Просим ввести пользователя трехзначное число
// создаем переменную и тут же запрашиваем в консоли полязователя ввести цифру, которая помещается в эту переменную 
// мы попробовали ввести отрицательное число и он нам выдавал последнее число тоже отрицательное
// запустили цикл, если пользователь вводит отрицательное число.
// Мы пишим if < 0
// Выводим на экран Крайняя цифра введеного числа: {a * -1 % 10}") - (формулой a * -1, мы переводим из отрицательного, в положительный формат, и делаем кратной 10, и остаток будет последнее число)
// а если же пользователь ввел положительное число, то Крайняя цифра введеного числа: {a % 10}


// Задачо 0
// Напишите программу, которая
// 1. на вход принимает число
// 2. и выдает его квадрат (число
// умноженное на само себя).
// Например: 4->16, -3->9 -7->49

// Console.WriteLine("Введите целое число");
// int nun = Convert.ToInt32(Console.ReadLine());
// int square = nun * nun;
// Console.Write($"Квадрат числа {nun} = {square}"); 

// Задача 1.
// Напишите программу
// 1. которая на вход принимает два числа
// 2.и проверяет, является ли первое число квадратом второго..
// // a = 25, b = 5 - > да, // a = 2; b = 10 - > нет
// // a = 9; b = - 3 - > да, // a = -3; b = 9 - > нет

// Console.WriteLine("Ведите целое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите еще одно число");
// int b = Convert.ToInt32(Console.ReadLine());

// if (b*b == a) Console.WriteLine($" Число {a} является квадратом числа {b}");
// else Console.WriteLine($" Число {a} не является квадратом числа {b}");

// Задача 3.
// // Напишите программу, которая будет выдавать
// // название дня недели по заданному номеру.
// // 3 -> Среда
// // 5 - > Пятница

// Console.WriteLine("Введите целое число в диапозоне от 1 до 7");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a == 1) Console.WriteLine("Понедельниик");
// else if (a == 2) Console.WriteLine("Вторник");
// else if (a == 3) Console.WriteLine("Среда");
// else if (a == 4) Console.WriteLine("Четверг");
// else if (a == 5) Console.WriteLine("Пятница");
// else if (a == 6) Console.WriteLine("Суббота");
// else if (a == 7) Console.WriteLine("Воскресеье");
// else Console.Write("Число не в диапозоне от 1 до 7");

// Задача 5. Напишите программу, которая на вход принимеает 
// одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 - > -4,-3,-2,-1, 0,1,2,3,4

// Первый вариант

// Console.WriteLine("Введите целое число");
// int nun = Convert.ToInt32(Console.ReadLine());
// int nun2 = - nun;
// while(nun2 <= nun)
// {
//     Console.Write(nun2+ " ");
//     nun2++;
// }

// Console.WriteLine("Введите целое число");
// int nun = Convert.ToInt32(Console.ReadLine());
// int nun2 = - nun;
// while(nun2 <= nun)
// {
//     Console.Write(nun2+ " ");
//     nun2++;
// }

// Второй вариант

// Console.WriteLine("Введите целое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вывод чисел в промежутке от N до N");
// for (int i = -a; i <= a; i++)
// {
//     Console.Write(i+ " ");
// }

// Console.Write("Напишите целое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вывод чисел в промежутке от N до N");
// for (int i = -a; i <= a; i++)
// {
//      Console.Write(i + " ");
// }
