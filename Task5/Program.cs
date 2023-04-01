// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int MaxDigit(int number)
{
    int dec = number % 10;
    int max = 0;
    while (number > 0)
    {
        int ost = number % 10;
        if (max < ost)
        {
            max = ost;
        }
        number /= 10;

    }
    return max;
}

int num = new Random().Next(10, 10000);

System.Console.WriteLine($"Максимальная цифра {MaxDigit(num)} из числа {num}");
