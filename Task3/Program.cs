// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num1 = ReadInt("Ведите число 1");
int num2 = ReadInt("Ведите число 2");
int a = num1 % num2;
int b = num2 % num1;

if (a == 0)
{
    System.Console.WriteLine("Второе число кратно первому");
}
else if (b == 0)
{
    System.Console.WriteLine("Первое число кратно второму");
}
else
{
    System.Console.WriteLine($"Числа не кратны, остаток от деления числа 2 на число 1 равен {a}, остаток от деления числа 1 на число 2 равен {b}");
}

