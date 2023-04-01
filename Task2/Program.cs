// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int num = new Random().Next(10, 100);

int MaxNumber(int number)
{
    int dec = number / 10;
    int det = number % 10;
    int result = dec;

    if (det > result)
    {
        result = det;
    }
    return result;
}

System.Console.WriteLine($"максимальный цифра из числа{num} > {MaxNumber(num)}");
