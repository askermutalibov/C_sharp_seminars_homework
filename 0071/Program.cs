// Написать программу вычисления функции Аккермана

/* 
A(m, n) = n + 1 | if m = 0
A(m, n) = (m - 1, 1) | if m > 0 and n = 0
A(m, n) = A(m - 1, A(m, n - 1)) | if m > 0 and n > 0
*/

int countAkkerman(int m, int n)
{
    if (m < 0 || n < 0) return 0; // Функция Аккермана работает только с положительными числами
    if (m == 0) return n + 1; // этот цикл реализуется только при заданном пользователем n == 0
    else if (m > 0 && n == 0) return countAkkerman((m - 1), 1); // этот цикл будет реализован после цикла ниже со входом в рекурсию, значения пары чисел в тексте вывода в консоль определяются в зависимости от той пары чисел, которая указана в последней строке алгоритма - вызова метода
    else return countAkkerman((m - 1), countAkkerman(m, (n - 1)));
}
/* Console.Write($"\nФункция Аккермана от пары чисел (-2, -1) равна "); Console.Write(countAkkerman(-2, -1)); */ // 0
Console.Write($"\nФункция Аккермана от пары чисел (0, 1) равна "); Console.Write(countAkkerman(0, 1)); // 2
Console.Write($"\nФункция Аккермана от пары чисел (1, 0) равна "); Console.Write(countAkkerman(1, 0)); // 2
Console.Write($"\nФункция Аккермана от пары чисел (1, 1) равна "); Console.Write(countAkkerman(1, 1)); // 3
Console.Write($"\nФункция Аккермана от пары чисел (2, 1) равна "); Console.Write(countAkkerman(2, 1)); // 5
Console.Write($"\nФункция Аккермана от пары чисел (2, 2) равна "); Console.Write(countAkkerman(2, 2)); // 7
Console.Write($"\nФункция Аккермана от пары чисел (3, 2) равна "); Console.Write(countAkkerman(3, 2)); // 29
Console.Write($"\nФункция Аккермана от пары чисел (3, 3) равна "); Console.Write(countAkkerman(3, 3)); // 61

/* Console.Write($"\nФункция Аккермана от пары чисел (4, 3) равна "); Console.Write(countAkkerman(4, 3)); */ // Stack Overflow. Repeat 16059 times - это предел мощностей для вычисления значения функции