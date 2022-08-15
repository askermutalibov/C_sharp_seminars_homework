// Вывести на экран кубы чисел от 1 до N

Console.Write("Введите целое число больше 2 (например 3 или 7): "); // больше 2 для корректной работы методов
string? FromUserString = Console.ReadLine();
int FromUserConvert = Convert.ToInt32(FromUserString);

void FillArray(int[] FromOneToNumberByUser) // метод заполнения массива рандомными элементами
{
    int length = FromOneToNumberByUser.Length;
    int index = 0;
    while (index < length)
    {
        FromOneToNumberByUser[index] = new Random().Next(1, FromUserConvert);
        index++;
    }
}
int[] UnFilledArray = new int[((Int32.MaxValue) / 100)]; // ввёл константу для самых любопытных юзеров и тестировщиков, пожелающих проверить очень большие числа, а деление на 100 добавил потому, что заполнение массива вплоть до максимальной константы приводит к ошибке "Out of memory", мой ноутбук такие вычисления провести не может :)
FillArray(UnFilledArray);

void SortArrayFromMinToMax(int[] UnFilledArray) // метод сортировки массива
{
    int length = UnFilledArray.Length;
    int index = 0;
    UnFilledArray[0] = 1;
    while (index < length && index < FromUserConvert)
    {
        if (UnFilledArray[(index)] < UnFilledArray[(index + 1)]) // перемещение меньшего элемента влево
        {
            UnFilledArray[index] = index + 1;
            index++;
        }
        else
        {
            UnFilledArray[index] = index;
            index++;
        }
    }
}
SortArrayFromMinToMax(UnFilledArray); // в этой версии задачи в методе есть ошибка, поскольку в отсортированном массиве есть повторяющиеся элементы

void Cubes(int[] UnFilledArray) // метод возведения числа в куб
{
    int index = 0;
    while (index < FromUserConvert)
    {
        Console.WriteLine($"куб числа {UnFilledArray[index]} равен {((UnFilledArray[index]) * (UnFilledArray[index]) * (UnFilledArray[index]))}");
        index++;
    }
}
Cubes(UnFilledArray);