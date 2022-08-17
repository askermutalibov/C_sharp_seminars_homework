// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число, для которого необходимо рассчитать его факториал: ");

string? FactorialString = Console.ReadLine();
int FactorialOfNumber = Convert.ToInt32(FactorialString);
int i = 1;
int Factorial = 1;
while (i <= FactorialOfNumber)
{
    Factorial = Factorial * (i + 1);
    i++;
    if (i == FactorialOfNumber)
    {
        Console.WriteLine($"факториал числа {FactorialOfNumber} равен {Factorial}");
    }
}