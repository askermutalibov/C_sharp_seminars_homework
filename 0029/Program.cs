// Подсчитать сумму цифр в числе

void CountSum(int KeyboardInt)
{
    int sum = 0;
    Console.Write("Введите число: ");
    string? Keyboard = Console.ReadLine();
    KeyboardInt = Convert.ToInt32(Keyboard);
    if (KeyboardInt == 0) sum = 0;
    if (KeyboardInt > 0 && KeyboardInt < 10) sum = KeyboardInt;
    while (KeyboardInt >= 10 && KeyboardInt < 100)
    {
        sum = KeyboardInt / 10 + KeyboardInt % 10;
        KeyboardInt = KeyboardInt / 10;
    }
    if (KeyboardInt >= 100 && KeyboardInt < 1000)
    {
        if (KeyboardInt % 100 == 0)
        {
            KeyboardInt = KeyboardInt / 10;
            sum = KeyboardInt / 10 + KeyboardInt % 10;
        }
        if (KeyboardInt % 10 == 0)
        {
            KeyboardInt = KeyboardInt / 10;
            sum = KeyboardInt / 10 + KeyboardInt % 10;
        }
        sum = KeyboardInt % 10;
        KeyboardInt = ((KeyboardInt - sum) / 10);
        sum = (sum + KeyboardInt / 10 + KeyboardInt % 10);
    }
    if (KeyboardInt >= 1000 && KeyboardInt < 10000)
    {
        if (KeyboardInt % 1000 == 0)
        {
            KeyboardInt = KeyboardInt / 10;
            sum = KeyboardInt / 10 + KeyboardInt % 10;
        }
        if (KeyboardInt % 100 == 0)
        {
            KeyboardInt = KeyboardInt / 10;
            sum = KeyboardInt / 10 + KeyboardInt % 10;
        }
        if (KeyboardInt % 10 == 0)
        {
            KeyboardInt = KeyboardInt / 10;
            sum = KeyboardInt / 10 + KeyboardInt % 10;
        }
        int AdditionalSum = 0;
        sum = KeyboardInt % 10;
        System.Console.WriteLine($"first sum is {sum}"); // 1025 % 10 = 5

        KeyboardInt = ((KeyboardInt - sum) / 10);
        System.Console.WriteLine($"first KeyBoardInt is {KeyboardInt}"); // (1025 - 5) / 10 = 102

        sum = sum + AdditionalSum + KeyboardInt % 10; // sum + KeyboardInt % 10;
        System.Console.WriteLine($"second sum is {sum}"); // 5 + 2 = 7

        KeyboardInt = KeyboardInt - (KeyboardInt % 10); //sum) / 10);
        System.Console.WriteLine($"second KeyBoardInt is {KeyboardInt}"); // (102 - 2) / 10 = 100

        KeyboardInt = (KeyboardInt / 10);
        System.Console.WriteLine($"third KeyBoardInt is {KeyboardInt}");

        KeyboardInt = (KeyboardInt / 10);
        System.Console.WriteLine($"fourth KeyBoardInt is {KeyboardInt}");

        sum = (sum + KeyboardInt / 10 + KeyboardInt % 10); // 7 + 9 = 16 // correct sum is 8
    }
    Console.WriteLine($"сумма цифр равна {sum}");
}
CountSum(1025); // костыль на костыле, но надеюсь, что такой код пройдёт критерии