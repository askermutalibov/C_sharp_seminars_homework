// Найти сумму цифр числа

int CountSum(int integer)
{
   if (integer == 0) return 0;
   else if (integer > 0 && integer < 10) return integer;
   else return (integer % 10) + CountSum(integer / 10);
}

Console.WriteLine(CountSum(123581321));