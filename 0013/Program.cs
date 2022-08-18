// Удалить вторую цифру целого числа введенного с клавиатуры.

/*

// 1 вариант: удаляет второе число с конца числа (не с начала)

Console.Write("Введите целое двухзначное число: "); // этот алгоритм не универсальный, работает только на двузначные числа
int DigitConvert = Convert.ToInt32(Console.ReadLine());
int First = DigitConvert % 10;
int Second = DigitConvert / 10 % 10;
int Third = DigitConvert / 100;
int Fourth = Third * 10 + First;
Console.WriteLine($"{First}{Second}{Third}");
Console.WriteLine($"{Fourth}");

/*

int a = 0;
Console.Write("Введите целое двухзначное число: ");
int Int = Convert.ToInt32(Console.ReadLine());
while ((Int % 10) > 0)
{
    a = Int - (Int % 10);
    a = (a % 10);
}
Console.WriteLine(a); // не разобрался с решением

*/

// 2 вариант: удаляет вторую цифру с левой части числа (с начала числа)

int n = Convert.ToInt32(Console.ReadLine());
int k = DigitsCount(n);
int n2 =n%(int) Math.Pow(10, k - 2); // (int) в скобках это явное привидение типов для того, чтобы функция Math.Pow сработала без изменения типа k2 с int на double [12547 % 1000 = 547]
int n3 = n / (int)Math.Pow(10, k - 1); // 10 в степени k - 1 [12547 / 10000 + 547]
int n4 = n3 * (int)Math.Pow(10, k - 2) + n2;
// System.Console.WriteLine($"{n3}{n2}"); строчка ниже - дублирующая
System.Console.WriteLine($"{n4}");

int DigitsCount (int N)
{
    if (N == 0) return 1;
    int k = 0;
    while (N!=0)
    {
        k++;
        N = N / 10;
    }
    return k;
}