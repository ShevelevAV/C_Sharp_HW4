/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} составит {Exp(A, B)}");
int Exp(int number1, int number2)
{
    int sum = 1;
    while (number2 >= 1)
    {
        sum = sum * number1;
        number2--;
    }
    return sum;

}