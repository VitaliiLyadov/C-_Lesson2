// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Ведите цифру от 1 до 7");

if (num > 7 || num < 0)
{
    System.Console.WriteLine("Это не день недели");
}
else if (num < 6)
{
    System.Console.WriteLine("Будний день");
}
else
{
    System.Console.WriteLine("Ура, выходной!!!");
}