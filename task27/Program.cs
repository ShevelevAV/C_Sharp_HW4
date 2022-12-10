/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N} -> {SumOfNum(N)}");
int SumOfNum(int number)
{
    int sum = 0;
    while(number>=1)
    {
        int temp = number%10;
        sum = sum + temp;
        number = number/10;
    }
    return sum;
}