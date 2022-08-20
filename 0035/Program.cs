// Написать программу замены элементов массива на противоположные

int[] originArray;
int arrayLength = 200;
originArray = new int[arrayLength];
Random originRandom = new Random();

int[] oppositeArray; // обяъвление второго массива для создания противоположного
oppositeArray = new int[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    originArray[i] = originRandom.Next(-100, (arrayLength + 1)); // наполнение массива псевдослучайными элементами
}

Console.WriteLine(); // ввод пустой строки для простоты считывания результатов алгоритма с экрана
Console.Write($"Первоначальная версия массива выглядит так: ["); // ввод инициализатора массива "для красоты"

for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"{originArray[i],6}");
}
Console.Write($" ]"); // ввод инициализатора массива "для красоты"
Console.WriteLine();

for (int i = 0; i < arrayLength; i++)
{
    oppositeArray[i] = (originArray[i] * (-1)); // замена массива на противоположный через умножение всех исходных элементов массива на (-1)
}

Console.WriteLine();
Console.Write("Видоизменённая версия массива выглядит так: [");

for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"{oppositeArray[i],6}");
}
Console.Write($" ]");
Console.WriteLine();