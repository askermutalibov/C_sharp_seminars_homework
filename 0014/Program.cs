// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

double FirstNumber;
double SecondNumber;
Console.Write("Введите первое число: ");
string? s=Console.ReadLine();
FirstNumber = Convert.ToDouble(s);
Console.Write("Введите второе число: ");
string? w=Console.ReadLine();
SecondNumber = Convert.ToDouble(w);

if ((FirstNumber % SecondNumber)==0)// алгоритм написан так, что 1-е число должно быть больше второго, хотя технически это никак не выделяется, так как 4 не может быть кратно 16, а если всё-таки может, то как не стыдно автору кода (мне)?
{
    Console.Write("Число a кратно числу b");
}
else
    {
        Console.Write("Число a не кратно числу b, остаток от деления числа a на число b равен ");
        Console.Write((FirstNumber % SecondNumber));
    }