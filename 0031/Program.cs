// Показать кубы чисел, заканчивающихся на чётную цифру

Console.Write("Введите число, которое будет верхним пределом последовательности чисел, для которой нужно вывести на экран кубы чётных чисел из этой последовательности: ");

string? CubesString = Console.ReadLine();
int CubesInt = Convert.ToInt32(CubesString);

int count = 2;
int Cube = 0;

while ((count <= CubesInt) && (count % 2 == 0))
{
    Cube = (CubesInt * CubesInt * CubesInt);
    count = (count + 2);
    if ((count == CubesInt))
    {
        Console.WriteLine($"куб числа {CubesInt} равен {Cube}");
    }
}