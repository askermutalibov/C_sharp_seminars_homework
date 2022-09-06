﻿// Написать программу вычисления функции Аккермана

/* 
A(m, n) = n + 1 | if m = 0
A(m, n) = (m - 1, 1) | if m > 0 and n = 0
A(m, n) = A(m - 1, A(m, n - 1)) | if m > 0 and n > 0
*/

void countAkkerman(int m, int n)
{
    if (m < 0 || n < 0) Console.WriteLine("Расчёт значений по функции Аккермана работает только при заданных положительных числах. Задайте, пожалуйста, пару положительных чисел и повторите попытку.");
    if (m == 0) Console.WriteLine($"Функция Аккермана к паре чисел (0, {n}) равна {n + 1}"); // этот цикл реализуется только при заданном пользователем n == 0
    else if (m > 0 && n == 0) Console.WriteLine($"Функция Аккермана к паре чисел (12, 7) равна ({m - 1}, {1})"); // этот цикл будет реализован после цикла ниже со входом в рекурсию, значения пары чисел в тексте вывода в консоль определяются в зависимости от той пары чисел, которая указана в последней строке алгоритма - вызова метода
    else if (m > 0 && n > 0)
    {
        int result = m - 1;
        countAkkerman(m, n - 1);
    }
}

countAkkerman(12, 7);