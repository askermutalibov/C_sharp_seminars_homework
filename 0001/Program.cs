/*
int FirstNumber = 1; // целые числа
double SecondNumber = 2; // вещественные числа
Console.WriteLine(int.MaxValue); // макс. значение целого числа для системы
Console.WriteLine(double.MaxValue); // макс. значение вещественного числа для системы
*/

/*
int FirstNumber = 1658;
int SecondNumber = FirstNumber * FirstNumber;
System.Console.WriteLine(SecondNumber);
*/

/*
int FirstNumber = 525;
int SecondNumber = FirstNumber * FirstNumber;
System.Console.WriteLine($"{FirstNumber}^2={SecondNumber}");
System.Console.WriteLine("{0}^2={1}", FirstNumber,SecondNumber); // строка форматирования
System.Console.WriteLine($"{FirstNumber}^2={SecondNumber}"); // строка интерполяции
*/

/*
string? s; // объявление переменной
s = Console.ReadLine(); // присвоение значения
System.Console.WriteLine(s);
*/

/*
int a;
int b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");
*/ // алгоритм, который выводит квадрат числа, введённого пользователем в терминал самостоятельно

double a;
double b;
string? s = Console.ReadLine();
a = Convert.ToDouble(s);
b = a * a;
System.Console.WriteLine($"{a}^2={b}");