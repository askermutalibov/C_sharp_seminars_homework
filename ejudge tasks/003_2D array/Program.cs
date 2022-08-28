// В квадратной таблице n x n (100 >= n >= 1) подсчитать сумму натуральных целых чисел, стоящих на главной диагонали (у этих элементов индексы совпадают: 0,0; 1,1; 2,2 и пр) и сумму натуральных целых чисел на побочной диагонали

Console.WriteLine("Введите 2 одинаковых целых числа для определения размера массива (первое число определяет количество строк, второе - количество столбцов (количество столбцов и строк должно быть больше 1): ");
string readNumbers = Console.ReadLine();
Console.WriteLine(); // для отделения длины массива по строкам и столбцам от самого массива с конкретными элементами
int n = int.Parse(readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int m = int.Parse(readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
int[,] squareArray = new int[n, m];

Console.WriteLine($"Введите {n} чисел подряд одной строкой через пробел и {m} чисел подряд через клавишу Enter для заполнения столбцов массива: ");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    readNumbers = Console.ReadLine();
    string[] splitArr = readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < splitArr.Length; j++)
    {
        squareArray[i, j] = int.Parse(splitArr[j]);
    }
}
Console.WriteLine(); Console.WriteLine("Ваш массив выглядит так: ");

for (int i = 0; i < squareArray.GetLength(0); i++)
{
    for (int j = 0; j < squareArray.GetLength(1); j++)
    {
        Console.Write($"{squareArray[i, j]} ");
    }
    Console.WriteLine();
}

int sumMain = 0;
int sumAdditional = 0;
for (int i = 0; i < squareArray.GetLength(0); i++)
{
    sumMain = sumMain + squareArray[i, i];
    sumAdditional = sumAdditional + squareArray[i, n - i - 1];
}

Console.WriteLine($"Сумма чисел, расположенных на главной диагонали матрицы (двумерного массива) равна {sumMain}");
Console.WriteLine();
Console.WriteLine($"Сумма чисел, расположенных на побочной диагонали матрицы (двумерного массива) равна {sumAdditional}");
Console.WriteLine();