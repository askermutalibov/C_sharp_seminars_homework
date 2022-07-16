// Выяснить является ли число чётным.

double Number;
string ? s = Console.ReadLine();
Number = Convert.ToDouble(s);

if (Number%2 == 0) // если остаток от деления числа на 2 равен нулю, то число чётное, иначе - нечётное
{
    Console.WriteLine("Введённое вами число чётное");
}
else
{
    Console.WriteLine("Введённое вами число нечётное");
}