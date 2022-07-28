// Программа проверяет является ли пятизначное число палиндромом

Console.Write("Введите пятизначное число отдельно по каждой цифре. Первая цифра пятизначного числа: ");
string? FirstDigitFromUser = Console.ReadLine();
int FirstDigitFromUserInteger = Convert.ToInt32(FirstDigitFromUser);

Console.Write("Вторая цифра пятизначного числа: ");
string? SecondDigitFromUser = Console.ReadLine();
int SecondDigitFromUserInteger = Convert.ToInt32(SecondDigitFromUser);

Console.Write("Третья цифра пятизначного числа: ");
string? ThirdDigitFromUser = Console.ReadLine();
int ThirdDigitFromUserInteger = Convert.ToInt32(ThirdDigitFromUser);

Console.Write("Четвёртая цифра пятизначного числа: ");
string? FourthDigitFromUser = Console.ReadLine();
int FourthDigitFromUserInteger = Convert.ToInt32(FourthDigitFromUser);

Console.Write("Пятая цифра пятизначного числа: ");
string? FifthDigitFromUser = Console.ReadLine();
int FifthDigitFromUserInteger = Convert.ToInt32(FifthDigitFromUser);

int[] FiveDigitNumber = new int [5] {FirstDigitFromUserInteger, SecondDigitFromUserInteger, ThirdDigitFromUserInteger, FourthDigitFromUserInteger, FifthDigitFromUserInteger};

int[] ReverseFiveDigitNumber = new int[5] {FifthDigitFromUserInteger, FourthDigitFromUserInteger, ThirdDigitFromUserInteger, SecondDigitFromUserInteger, FirstDigitFromUserInteger};

if (FiveDigitNumber[0] == ReverseFiveDigitNumber[4] & FiveDigitNumber[1] == ReverseFiveDigitNumber[3] & FiveDigitNumber[2] == ReverseFiveDigitNumber[2] & FiveDigitNumber[3] == ReverseFiveDigitNumber[1] & FiveDigitNumber[4] == ReverseFiveDigitNumber[0])
{
    System.Console.WriteLine("это число - палиндром");
}
else
{
    if (FiveDigitNumber[0] != ReverseFiveDigitNumber[0] | FiveDigitNumber[0] != ReverseFiveDigitNumber[1] | FiveDigitNumber[0] != ReverseFiveDigitNumber[2] | FiveDigitNumber[0] != ReverseFiveDigitNumber[3] | FiveDigitNumber[0] != ReverseFiveDigitNumber[4] | FiveDigitNumber[1] != ReverseFiveDigitNumber[0] | FiveDigitNumber[1] != ReverseFiveDigitNumber[1] | FiveDigitNumber[1] != ReverseFiveDigitNumber[2] | FiveDigitNumber[1] != ReverseFiveDigitNumber[3] | FiveDigitNumber[1] != ReverseFiveDigitNumber[4] | FiveDigitNumber[2] != ReverseFiveDigitNumber[0] | FiveDigitNumber[2] != ReverseFiveDigitNumber[1] | FiveDigitNumber[2] != ReverseFiveDigitNumber[2] | FiveDigitNumber[2] != ReverseFiveDigitNumber[3] | FiveDigitNumber[2] != ReverseFiveDigitNumber[4] | FiveDigitNumber[3] != ReverseFiveDigitNumber[0] | FiveDigitNumber[3] != ReverseFiveDigitNumber[1] | FiveDigitNumber[3] != ReverseFiveDigitNumber[2] | FiveDigitNumber[3] != ReverseFiveDigitNumber[3] | FiveDigitNumber[3] != ReverseFiveDigitNumber[4] | FiveDigitNumber[4] != ReverseFiveDigitNumber[0] | FiveDigitNumber[4] != ReverseFiveDigitNumber[1] | FiveDigitNumber[4] != ReverseFiveDigitNumber[2] | FiveDigitNumber[4] != ReverseFiveDigitNumber[3] | FiveDigitNumber[4] != ReverseFiveDigitNumber[4])
    {
        System.Console.WriteLine("это число - не палиндром");
    }
} // это нерабочий алгоритм, но у меня больше нет сил разбираться с этой задачей...