// Написать программу преобразования десятичного числа в двоичное


int n = 123456789;
Console.WriteLine();
Console.WriteLine($"Число {n} в десятичной системе счисления будет записано как {DecimalToBinary(n)} в двоичной системе счисления");

string DecimalToBinary(int n)
{
    string s = "";
    while (n != 0)
    {
        s = (n % 2).ToString() + s;
        n /= 2; // n = n/2
    }
    return s;
}
