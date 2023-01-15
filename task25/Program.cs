// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

int getPowerNumber(int A, int B)
{
    int power_number = 1;
    for (int i = 1; i<= B; i++)
    {
        power_number = power_number*A;
    } 
    return power_number;
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(data);
    Console.ResetColor();
}

int number = getUserData("Введите число A");
int power = getUserData("Введите число B");

int result = getPowerNumber(number, power);

showData($"Число {number} в степени {power} = ", result);