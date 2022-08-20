// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] eightArray;
eightArray = new int[8];
Random random = new Random();

for (int i = 0; i < eightArray.Length; i++)
{
    eightArray[i] = random.Next(0, 2);
}

for (int i = 0; i < eightArray.Length; i++)
{
    System.Console.Write($"{eightArray[i], 5}");
}