// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

int getSumNumber(int number)
{
    int summ_number = 0;
    while (number>0)
    {
        summ_number = summ_number + number%10;
        number = number/10;
    } 
    return summ_number;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(data);
    Console.ResetColor();
}

int number = getUserData("Введите число N");

int result = getSumNumber (number);

showData($"Сумма цифр числа {number} = ", result);