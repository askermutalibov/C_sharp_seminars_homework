// Найти минимальное число в массиве n (100 >= n >= 1) строк x m (100 >= m >= 1) столбцов из натуральных целых чисел < 1000


Console.WriteLine("Введите 2 целых числа для определения размера массива (первое число определяет количество строк, второе - количество столбцов (количество столбцов и строк должно быть больше 1): ");
string readNumbers = Console.ReadLine();
Console.WriteLine(); // для отделения длины массива по строкам и столбцам от самого массива с конкретными элементами
int n = int.Parse(readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int m = int.Parse(readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
int[,] nmArr = new int[n, m];

Console.WriteLine($"Введите {n} чисел подряд одной строкой через пробел и {m} чисел подряд через клавишу Enter для заполнения столбцов массива: ");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    readNumbers = Console.ReadLine();
    string[] splitArr = readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < splitArr.Length; j++)
    {
        nmArr[i, j] = int.Parse(splitArr[j]);
    }
}
int minI = 0;
int minJ = 0;
int min = nmArr[0, 0];

for (int i = 0; i < nmArr.GetLength(0); i++)
{
    for (int j = 0; j < nmArr.GetLength(1); j++)
    {
        if (nmArr[i, j] < min)
        {
            min = nmArr[i, j];
            minI = i;
            minJ = j;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальный элемент данного массива равен {nmArr[minI, minJ]} и находится на {minI} строке {minJ} столбца");
Console.WriteLine();