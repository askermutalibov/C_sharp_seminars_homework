﻿// Написать программу вычисления значения функции y = sin(a). (Класс Math). 


double Angle; // ввод переменной, обозначаемой угол
string? s = Console.ReadLine(); // строковая переменная, помогающая мне решить все эти задачи :)
Angle = Convert.ToDouble(s); // запись в переменную значения градуса угла
Console.Write("Синус угла "); Console.Write(Angle); Console.Write(" градусов равен "); // не разобрался, как в одну строку Console.Write вписать и текст для вывода и значение переменной, рассчитаной алгоритмом, поэтому выглядит немного коряво и тяжеловесно
Console.Write(Math.Sin(Angle));
