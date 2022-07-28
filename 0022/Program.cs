// Программа проверяет является ли пятизначное число палиндромом

Console.Write("Введите 5-ти значное число: ");
string number = Console.ReadLine()!;
void Task22(string number )
{
    
    if (number [0] == number [4] && number [1] == number [3])
    {
    Console.WriteLine("Данное число - палиндром");
    }
    else
Console.WriteLine("Данное число не палиндром");
 
}
Task22(number);