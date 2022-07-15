// Вывести на экран 2-ю с конца цифру числа (56 = 5)

int FirstNumber = 4527;
int SecondNumber = FirstNumber/10;
int ThirdNumber = FirstNumber/10%10;
// System.Console.WriteLine(SecondNumber); лишняя итерация
System.Console.WriteLine(ThirdNumber);