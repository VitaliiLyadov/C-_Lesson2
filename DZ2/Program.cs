// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета (решать только при помощи операций % и /).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Ведите число ");

bool Number(int number)
{
    if (num < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int Three(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}
if (Number(num))
{
    System.Console.WriteLine(Three(num));
}