﻿// 5.Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от - N до N
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"



// Console.Write("Напишите целое число "); - Выводим на экран 
// int a = Convert.ToInt32(Console.ReadLine()); - Создаем переменную и одновременно  
//запрашиваем в Console полязователя вести цифру, 
//которая помещается в эту переменную
//
// Console.Write("Вывод чисел в промежутке от N до N"); - Выводим на экран
// for (int i = -a; i <= a; i++) - используя цикл, мы создаем переменную i, 
// которая будет равна отрицательному числу a, который ввел пользователь
// и пока i ,будкт < = a, которую ввел пользователь, мы делаем цикт 
//и после прохождения каждом операции мы к i прибавляем + 1
//{
//    Console.Write(i + " ");  
//}

Console.Write("Напишите целое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Вывод чисел от N до N ");
for(int i = -a; i <= a; i++)
{
    Console.Write(i + " ");
}