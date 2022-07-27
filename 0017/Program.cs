// Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным

int[] month = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31}; // объявил массив, равный дням в месяце
int index = month[0]; // счётчик, равный нулевому индексу массива - 1 числу месяца

System.Console.Write("Введите число: "); // без этого никуда
string? s = Console.ReadLine();
int read = Convert.ToInt32(s); // перевод строковой переменной в интеджер

if (read == month[0] || read == month[1] || read == month[2] ||  read == month[3] ||  read == month[4] ||  read == month[7] ||  read == month[8] ||  read == month[9] ||  read == month[10] ||  read == month[11] ||  read == month[14] ||  read == month[15] ||  read == month[16] ||  read == month[17] ||  read == month[18] ||  read == month[21] ||  read == month[22] ||  read == month[23] ||  read == month[24] ||  read == month[25] ||  read == month[28] ||  read == month[29] || read == month[30] ) // костыльный подход, скорее всего, но функцией это реализовать не удалось
{
    Console.WriteLine("Сегодня будний день");
}
else
{
    if (read == month[5] || read == month[6] || read == month[12] || read == month[13] || read == month[19] || read == month[20] || read == month[26] || read == month[27] )
    {
        Console.WriteLine("Сегодня выходной день");
    }
    else Console.WriteLine("Введите число от 1 до 31 включительно");
} // но слава богу всё работает :)