// .NET variables

/*

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

int a, b;
a = 1;
b = 2;
System.Console.WriteLine($"{a} {b}");

a = b;
b = a;
System.Console.WriteLine($"{a} {b}");

a = a + b;
b = a - b;
a = a - b;
System.Console.WriteLine($"{a} {b}");