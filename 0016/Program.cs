// Дано число. Проверить кратно ли оно 7 и 23 одновременно

/* // пока сделаем из этого коммент
bool b;
b = true; // b = 1, равнозначно
b = false; // b = 0, равнозначно
b = 2*2!=5; // операторы сравнения: < > >= =< == (равно) != (не равно)
int x = 150;
b = x%7==0; // если остаток от деления числа х (150) на 7 равен 0, то число х кратно 7
System.Console.Write("this is ");
System.Console.Write(b);

*/

bool b, c, d;
int x = (23*21);
b = x%7==0;c = x%23==0;
d = b && c; // логическая укороченная конъюнкция: И первое И второе (одна из разновидностей логических операций)
Console.WriteLine(x);
// Console.WriteLine(b);
// Console.WriteLine(c);
Console.WriteLine(x%7==0 && x%23==0);
if (d)
{
    System.Console.WriteLine($"{x} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{x} не кратно 7 и 23");
}
//Console.WriteLine(d);