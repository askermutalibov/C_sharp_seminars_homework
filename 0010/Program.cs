// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

double Number;
Console.Write("Введите число: ");
string? s = Console.ReadLine();
Number = Convert.ToDouble(s);
Console.WriteLine(Number % 10);