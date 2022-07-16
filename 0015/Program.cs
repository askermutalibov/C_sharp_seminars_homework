// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

int FromKeyBoard;
Console.WriteLine("Введите целое число");
string? t = Console.ReadLine();
FromKeyBoard = Convert.ToInt32(t);

if ((FromKeyBoard)%100 > 0)
{
    Console.WriteLine("Третья цифра числа: "); Console.WriteLine((FromKeyBoard)%10);
}
else
{
    Console.WriteLine("Третья цифра числа отсутствует");// к сожалению алгоритм работает только для трёхзначных чисел
}

