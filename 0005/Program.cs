// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double FirstNumber; // в условии не указан вид числа - целое или вещественное, поэтому тип double
double SecondNumber;
double ThirdNumber;
double FirstMax; // переменная для записи максимального из первых 2 сравниваемых чисел
double Max; // переменная для записи максимального числа
Console.Write("Введите число: "); // просьба пользователю ввести число
string? s = Console.ReadLine(); // запись в строковую переменную числа, вводимого пользователем
FirstNumber = Convert.ToDouble(s);
Console.Write("Введите число: ");
s = Console.ReadLine();
SecondNumber = Convert.ToDouble(s);
Console.Write("Введите число: ");
s = Console.ReadLine();
ThirdNumber = Convert.ToDouble(s);
Console.Write("Введите число: ");

if (FirstNumber > SecondNumber)
{
    FirstMax = FirstNumber;
    if (FirstMax > ThirdNumber)
    {
        Max = FirstNumber;
        System.Console.WriteLine("Максимальное число: ");
        System.Console.WriteLine(FirstNumber);
    }
}
FirstMax = SecondNumber;

if (ThirdNumber > FirstMax)
{
    Max = ThirdNumber;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(ThirdNumber);
}

if (ThirdNumber < FirstMax)
{
    Max = FirstMax;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(FirstMax);
}