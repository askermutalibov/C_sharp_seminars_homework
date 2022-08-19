// 1. .NET variables

/* // .NET variables

// значимые типы данных (valuable types)
int a;
double b;
a = 4; // просто записывается

// ссылочные типы данных (reference types)
string c;
c = "Hello";
int[] array;
array = new int[5]; // объявляем массив со ссылкой на место в RAM, которое равняется числу в квадратных скобках (условно 5 битов, например)

*/

// arguments in C#
/*  // просто вывод записанных в переменные значений

int a, b;
a = 1;
b = 2;
System.Console.WriteLine($"{a} {b}");
*/
/* // нерабочий способ перезаписи значений в переменные
a = b;
b = a;
System.Console.WriteLine($"{a} {b}");
*/ // нерабочий способ, в a и b записываются 2 вместо 2 и 1
/* // один из способов перезаписи значений в переменные без создания и инициализации третьей переменной
a = a + b; // 3
b = a - b; // 1
a = a - b; // 2
System.Console.WriteLine($"{a} {b}");
*/

/* // один из способов перезаписи значений в переменные с помощью создания и инициализации третьей переменной t после объявления метода Swap с временными переменными a и b и модификаторами ссылочных аргументов ref
void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}
System.Console.WriteLine($"{a} {b}");
Swap(ref a, ref b); // ref - ссылка на изначачальный адрес хранения переменных a и b
System.Console.WriteLine($"{a} {b}");
*/

/* // один из способов перезаписи значений в переменные через инициализацию модификатора параметров out для обхода потенциальной ошибки комплилятора из-за неинициализированных переменных sum и sub с любым значением вне границ метода void
void Calculate(int a, int b, out int sum, out int sub)
{
    sum = a + b;
    sub = a - b;
}

int a, b, sum, sub;
a = 1;
b = 2;
Calculate(a, b, out sum, out sub);

*/

/* // обзор методов конвертации значений типа string в int (Convert.ToInt32(something); int.Parse(something); int.TryParse(first variable which need to be converted, out second variable which will be convertable type for 1st variable))

int ConvertExample = Convert.ToInt32(Console.ReadLine()); // 1-й способ конвертации string в int.

int ParseExample = int.Parse(Console.ReadLine()); // 2-й способ конвертации string в int.
string str;
int n;
bool f;
do
{
    str = Console.ReadLine();
    f = int.TryParse(str, out n);
    if (f == false) System.Console.WriteLine("Wrong input!"); // "защита от дурака", который будет вводить не то, что нужно

}
while (f == false);
System.Console.WriteLine(n);

*/