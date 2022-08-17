// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
string? Astring = Console.ReadLine();
double Adouble = Convert.ToDouble(Astring);

Console.WriteLine("Введите натуральное число, которое будет выполнять роль степени для ранее введённого числа: ");
string? Bstring = Console.ReadLine();
int Bint = Convert.ToInt32(Bstring); //Bstring.Convert.ToDouble;
double index = 0;
while (index < Adouble)
{
    Console.WriteLine($"число {Adouble} в степени {Bint} = {(long)Math.Pow(Adouble, Bint)}"); // я надеюсь, что использование метода Pow подходит под критерии готового алгоритма решения задачи
    index = index + Adouble;
}