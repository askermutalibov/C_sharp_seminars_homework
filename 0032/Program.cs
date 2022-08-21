// Задать массив из 8 элементов и вывести их на экран


/* 1-я версия алгоритма

int []t;
t = new int[8];
for (int i = 0; i < t.Length; i++)
t[i] = i*10;
for (int i = 0; i < t.Length; i++)
System.Console.WriteLine(
    $"a[{i}]={t[i]} "
);

*/
/* 2-я версия алгоритма (с методами void) */

int[] t;
// t = new int[8];
init(out t, 8, 0, 10);
Print(t, "t");

void init(out int[] t, int length, int min, int max)
{
    t = new int[length];
    Random random = new Random();
    for (int i = 0; i < t.Length; i++)
    {
        t[i] = random.Next(min, max + 1);
    }
}

void Print(int[] t, string variableName)
{
    for (int i = 0; i < t.Length; i++)
    {
        Console.WriteLine($" {variableName}[{i}] = {t[i]} ");
    }
}