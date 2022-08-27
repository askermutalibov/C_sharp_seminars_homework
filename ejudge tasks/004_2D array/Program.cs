// В матрице 3 x 2 (двумерном массиве) найти номер строки, сумма чисел в котороц максимальна.

Console.WriteLine("Введите 2 целых числа для определения размера массива (первое число определяет количество строк, второе - количество столбцов: ");
string read = Console.ReadLine();

int N = int.Parse(read.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int M = int.Parse(read.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
int[,] a = new int[N, M];

// console read line вместе со split вернёт string массив из строк ([0] - первый элемент). Дальше всё это парсируем в int
// StringSplitOptions.RemoveEmptyEntries удаляет пустые области в терминале для обхода ошибки ввода данных неверного формата

for (int i = 0; i < N; i++)
{
    string readthis = Console.ReadLine();
    string[] stringArray = readthis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < stringArray.Length; j++)
    {
        a[i, j] = int.Parse(stringArray[j]);
    } // 16 и 17 строки (условия в цикле for и тело цикла a[i, j] = int.Parse(stringArray[j]);) можно было заменить строкой int[] a = Array.ConvertAll<string, int>(stringArray, int.Parse); но далее нужно было бы создать массив массивов int[][], с ним мы ещё не работали
}

Print(a);

int maxindex = 0;

int CountSum(int maxindex)
{
    int imax = 0;
    int sum = 0;
    int max = 0;
    for (int i = 0; i < a.GetLength(0); i++) // считаем сумму наибольших элементов массива
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum = sum + a[i, j];
        }
        if (sum > max)
        {
            max = sum;
            imax = i; // с помощью вспомогательной переменной запоминаем строку, в которой хранятся элементы с максимальной суммой для их последующего вывода
        }
    }
    return imax;
    System.Console.Write($"{imax}");
}
CountSum(maxindex);
System.Console.WriteLine($"Строка массива, в которой расположены элементы с максимальной суммой среди всех элементов, хранящихся в массиве, расположена под индексом {CountSum(maxindex)} ");

void Print(int[,] a)
{
    Console.WriteLine();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}
