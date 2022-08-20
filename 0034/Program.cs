// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

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