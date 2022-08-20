// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[,] array = new double[1, 30]; // объявление двумерного массива с 1 строкой и 30 столбцами
double maxDouble = array[0, 1];
double minDouble = array[0, 2];
double diff = 0; // переменная для записи результата - разницы между максимумом и минимумом

Random arrayRand = new Random();
Console.WriteLine(); Console.WriteLine("Исходный массив вещественных чисел: ");
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 30; j++)
    {
        array[i, j] = arrayRand.NextDouble() * 1000; // инициализация массива из псевдослучайных чисел в диапазоне от 0 до 1 методом NextDouble() и умножение каждого элемента на 1000
        Console.Write("{0,9:F3}", array[i, j]); // добавление 9 знакомест между элементами массива и проставление 3 знаков после запятой к каждому элементу
        if (array[i, j] > maxDouble && array[i, j] > minDouble) maxDouble = (array[i, j]);
        if (array[i, j] < maxDouble && array[i, j] < minDouble) minDouble = (array[i, j]);
    }
    Console.WriteLine();
}
System.Console.WriteLine($"Минимальный элемент массива равен {minDouble}");
System.Console.WriteLine($"Максимальный элемент массива равен {maxDouble}");
diff = maxDouble - minDouble; // расчёт результата
System.Console.WriteLine(diff);