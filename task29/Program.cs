/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/


void FillArray(int[] fill)
{
    int index = 0;
    int leght = fill.Length;
    while (index < leght)
    {
        fill[index] = new Random().Next(1, 99);
        index++;
    }

}
void PrintArray(int[] prnt)
{
    int pos = 0;
    int count = prnt.Length;
    while (pos < count)
    {
        Console.Write($"{prnt[pos]} ");
        pos++;
    }

}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
