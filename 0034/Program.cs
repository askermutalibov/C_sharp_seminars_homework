// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

/* 1-я версия алгоритма

// initial array 
int N = 12;
int[] a = new int [N];
Random random = new Random(); // инициализируем метод генерации псевдослучайных чисел

// create rand array

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-9, 10);
}
int sumPositive = 0;
// print 
Console.WriteLine();

for (int i = 0; i < a.Length; i++)
{
    Console.Write($"{a[i],5}"); // выделяем 4 знакоместа (но можно это реализовать просто через пробелы)
}

// solution

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        sumPositive = sumPositive + a[i];
    }
}
Console.WriteLine(); Console.WriteLine(); Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");

int sumNegative = 0;
// print results

for (int i = 0; i < a.Length; i++)
{
    if (a[i] < 0)
    {
        sumNegative += a[i]; // запись sumNegative = sumNegative + a[i] и запись sumNegative += a[i] равноценны, выполняют одну и ту же итерацию
    }
}
System.Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");

// алгоритм в этой задаче реализован через подпрограммы, через множество циклов, каждый из которых выполняет свою задачу, поскольку так удобнее

*/ 

/* 2-я версия алгоритма c отдельными методами под каждую подзадачу */

int[] a;
init(out a, 12, -9, 9); Console.WriteLine();
Print(a, "a");
Solve(a, out int sumPositive, out int sumNegative);

void init(out int[] t, int length, int min, int max)
{
    t = new int[length];
    Random random = new Random();
    for (int i = 0; i < t.Length; i++)
    {
        t[i] = random.Next(min, max + 1);
    }
}

void Print(int[] a, string variableName)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($" {variableName}[{i}] = {a[i]} ");
    }
}

void Solve(int[] a, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0)
        {
            sumPositive += a[i];
        }
    }
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < 0)
        {
            sumNegative += a[i];
        }
    }
}

Console.WriteLine(); Console.WriteLine(); Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");

System.Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
