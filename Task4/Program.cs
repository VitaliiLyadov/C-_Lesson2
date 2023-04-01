// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Ведите число 1");

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число не кратно 7 и 23");
}
